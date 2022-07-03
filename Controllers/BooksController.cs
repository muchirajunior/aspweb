using System;
using System.Threading.Tasks;
using helloweb.Models;
using helloweb.Services;
using Microsoft.AspNetCore.Mvc;

namespace helloweb.Controllers
{
    public class BooksController : Controller{
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService){_bookService=bookService;}

        public ViewResult Index(){
          ViewBag.Book=_bookService.GetBookById(1);
          ViewBag.Name="Junior";
          return View();
        }
        public async Task<IActionResult> GetAllBooks(){
          var data= await _bookService.GetAllBooks();
          return View(data);
        }
        public async Task<IActionResult>  GetBook(int id){  
            var book=await _bookService.GetBookById(id);
            
            return View(book);
          }
          public IActionResult AddBook()=> View();
          
          [HttpPost]
          public async Task<IActionResult> AddBook(Book book)
          {
              Console.WriteLine($"Title {book.title} \nAuthor {book.author} \npages {book.pages} \ndescription: {book.description}");
              await _bookService.AddBook(book);
              return View();
          }
          
    }  
}