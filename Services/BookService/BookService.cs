using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using helloweb.Models;
using Microsoft.EntityFrameworkCore;
using programming.Models;

namespace helloweb.Services
{
    public class BookService : IBookService
    {
        private readonly DatabaseContext _context;
        public BookService(DatabaseContext databaseContext){_context=databaseContext;}

        public List<Book> GetAllBooks() {
            var AllBooks=  _context.books.ToList();

            return AllBooks;

        }

        public  Book GetBookById(int id) =>  _context.books.Where(book => book.id == id).FirstOrDefault();

        public  void AddBook(Book book){
             _context.books.Add(book);
             _context.SaveChanges();
        } 
    }
}