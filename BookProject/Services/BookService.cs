using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookProject.Models;

namespace BookProject.Services
{
    public class BookService : IBookService
    {
        private readonly List<Book> _books;
        public BookService()
        {
            _books = new List<Book>()
            {
                new Book()
                {
                     Id=1,
                      ImagePath="",
                       Title="Book 1"
                },
                new Book()
                {
                     Id=2,
                      ImagePath="",
                       Title="Book 2"
                },
                new Book()
                {
                     Id=3,
                      ImagePath="",
                       Title="Book 3"
                },
            };
        }
        public Book AddBook(Book book)
        {
            _books.Add(book);
            return book;
        }

        public IList<Book> GetAll()
        {
            return _books;
        }
    }
}
