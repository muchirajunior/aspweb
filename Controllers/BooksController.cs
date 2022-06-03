using System.Collections.Generic;
using helloweb.Models;
using helloweb.Services;
using Microsoft.AspNetCore.Mvc;

namespace helloweb.Controllers
{
    public class BooksController : Controller{
        private readonly BookService _bookService=new BookService();

        public ViewResult Index()=>View();
        public  IActionResult GetAllBooks(){
          var data= _bookService.GetAllBooks();
          return View(data);
        }
        public IActionResult GetBook(int id){
            var book=_bookService.GetBookById(id);
            return View(book);
          }
    }  
}