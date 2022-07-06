using System.Collections.Generic;
using System.Threading.Tasks;
using helloweb.Models;

namespace helloweb.Services{
      public interface IBookService
    {
        List<Book> GetAllBooks();
        Book GetBookById(int id);
        void AddBook(Book book);
    }

}