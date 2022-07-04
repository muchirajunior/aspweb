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

        public async Task<List<Book>> GetAllBooks() {
            var books= await _context.books.ToListAsync();

            return books;

        }

        public async Task<Book> GetBookById(int id) => await _context.books.Where(book => book.id == id).FirstOrDefaultAsync();

        public async Task AddBook(Book book){
            await _context.books.AddAsync(book);
            await _context.SaveChangesAsync();
        } 
    }
}