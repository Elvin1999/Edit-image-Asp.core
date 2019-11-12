using BookProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookProject.Services
{
   public interface IBookService
    {
        IList<Book> GetAll();
        Book AddBook(Book book);
    }
}
