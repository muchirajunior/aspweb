using System.Collections.Generic;
using System.Threading.Tasks;
using helloweb.Models;

namespace helloweb.Services{
      public interface IBookService
    {
        Task<List<Book>> GetAllBooks();
        Task<Book> GetBookById(int id);
        Task AddBook(Book book);
    }

}