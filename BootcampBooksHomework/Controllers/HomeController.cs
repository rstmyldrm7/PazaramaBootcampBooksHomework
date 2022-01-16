using BootcampBooksHomework.Models;
using BootcampBooksHomeworkBusiness.Abstract;
using BootcampBooksHomeworkCore.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootcampBooksHomework.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookService _bookService;
        public HomeController(IBookService bookService) //Constructorımızda context nesnemizi tanmımlıyoruz. 
        {
            _bookService = bookService;
        }

        public IActionResult Index() //Giriş sayfası kitapları listelemek için dönüş yapıyoruz.
        {
            var books = _bookService.GetBooks().ToList();
            var model = new HomePageViewModel()
            {
                books = books.ToList()
            };
            return View(model);
        }

    }
}
