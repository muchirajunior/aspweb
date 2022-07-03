using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using helloweb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using programming.Models;

namespace helloweb.Services{
    public class BookService : IBookService
    {
        private readonly DatabaseContext _context;
        public BookService(DatabaseContext databaseContext){_context=databaseContext;}
        private List<Book> books = new List<Book>(){
            // new Book(){id=1,title="ASP.NET book", author="Junior"},
            // new Book(){id=2,title="ASP.NET core book", author="James"},
            // new Book(){id=3,title="ASP.NET core mvc book", author="Jane"},
            // new Book(){id=4,title="Flutter book", author="Alex"},
            // new Book(){id=5,title="ASP.NET API book", author="Henery"}
        };

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