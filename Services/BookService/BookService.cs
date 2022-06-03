using System.Collections.Generic;
using System.Linq;
using helloweb.Models;

namespace helloweb.Services{
    public class BookService{
        private List<Book> books=new List<Book>(){
            new Book(){id=1,title="ASP.NET book", author="Junior"},
            new Book(){id=2,title="ASP.NET core book", author="James"},
            new Book(){id=3,title="ASP.NET core mvc book", author="Jane"},
            new Book(){id=4,title="Flutter book", author="Alex"},
            new Book(){id=5,title="ASP.NET API book", author="Henery"}
        };

        public List<Book> GetAllBooks()=> books;

        public Book GetBookById(int id)=> books.Where(book=>book.id==id).FirstOrDefault();
    }
}