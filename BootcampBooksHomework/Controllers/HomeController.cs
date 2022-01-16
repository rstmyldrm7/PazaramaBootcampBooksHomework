using BootcampBooksHomework.Models;
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
        private readonly BookContext _context;

        public HomeController(BookContext context) //Constructorımızda context nesnemizi tanmımlıyoruz. 
        {
            _context = context;
        }

        public IActionResult Index() //Giriş sayfası kitapları listelemek için dönüş yapıyoruz.
        {
            HomePageViewModel model = new HomePageViewModel();
            model.books = _context.Books.ToList();
            return View(model);
        }

    }
}
