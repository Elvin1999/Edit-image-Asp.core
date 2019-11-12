using BookProject.Models;
using BookProject.Services;
using BookProject.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace BookProject.Controllers
{
    public class BookController:Controller
    {
        private readonly IBookService _bookService;
        public BookController(IBookService _bookService)
        {
            this._bookService = _bookService;
        }
        public IActionResult Index()
        {
            var books = _bookService.GetAll();
            var vm = books.Select(x => new BookViewModel
            {
                Id=x.Id,
                Title = x.Title,
                ImagePath=x.ImagePath
            }).ToList();
            AllBookViewModel bookViewModel = new AllBookViewModel();
            bookViewModel.BookViewModels = vm;
            return View(bookViewModel);
        }
        public IActionResult EditImage(int id,IFormFile file)
        {
            var item=_bookService.GetAll().SingleOrDefault(x => x.Id == id);     
            if (file != null)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", file.FileName);
                
                using (var fs = new FileStream(path,FileMode.Create))
                {
                    file.CopyTo(fs);
                    var s = file.FileName.Split("\\");
                    var d = s[s.Length - 1];
                    item.ImagePath = d;
                }
            }
            return RedirectToAction("Index");
        }
    }
}
