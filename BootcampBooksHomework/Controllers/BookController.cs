using BootcampBooksHomeworkDTO.Entity;
using BootcampBooksHomework.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BootcampBooksHomeworkCore.Data;
using BootcampBooksHomeworkBusiness.Abstract;

namespace BootcampBooksHomework.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService) //Constructorımızda context nesnemizi tanmımlıyoruz. 
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var books = _bookService.GetBooks().ToList();
            return View(books);
        }

        [HttpGet]
        public IActionResult List(int? id, string q) //Listeleme, Id ile filtreleme ve search etme işlemleri için Actionumuz.
        {
            var resp = _bookService.List(id,q);
            var model = new BooksViewModel()
            {
                books = resp.ToList()
            };
            return View("Book", model);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(_bookService.Details(id));

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {

            return View(_bookService.Details(id));
        }

        [HttpPost]
        public IActionResult Edit(Book b)
        {
            var resp = _bookService.EditBook(b);
            return RedirectToAction("Details", "Book", new { @id = resp.BookId });
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book b)
        {
            _bookService.CreateBook(b);
            return RedirectToAction("List");
        }

        [HttpPost]
        public IActionResult Delete(int BookId, string Name)
        {
            _bookService.DeleteBook(BookId, Name);
            return RedirectToAction("List");
        }
    }
}
