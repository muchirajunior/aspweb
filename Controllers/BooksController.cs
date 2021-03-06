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

        public  IActionResult  Index(){
          ViewBag.Book=  _bookService.GetBookById(1);
          ViewBag.Name="Junior";
          return View();
        }
        public  IActionResult GetAllBooks(){
          var data=  _bookService.GetAllBooks();
          return View(data);
        }
        public  IActionResult  GetBook(int id){  
            var book= _bookService.GetBookById(id);

            return View(book);
          }
          public IActionResult AddBook()=> View();
          
          [HttpPost]
          public  IActionResult AddBook(Book book)
          {
              _bookService.AddBook(book);
              return Redirect("GetAllBooks");
          }
          
    }  
}