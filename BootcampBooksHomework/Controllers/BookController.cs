using BootcampBooksHomeworkDTO.Entity;
using BootcampBooksHomework.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BootcampBooksHomeworkCore.Data;

namespace BootcampBooksHomework.Controllers
{
    public class BookController : Controller
    {
        private readonly BookContext _context;
        public BookController(BookContext context) //Constructorımızda context nesnemizi tanmımlıyoruz. 
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var books = _context.Books.ToList();
            return View(books);
        }

        [HttpGet]
        public IActionResult List(int? id, string q) //Listeleme, Id ile filtreleme ve search etme işlemleri için Actionumuz.
        {
            var books = _context.Books.AsQueryable();

            if (id != null) //Books7List/1 tipinde çağırım esnasında çalışacak kod parçası.
            {
                books = books
                    .Include(m => m.Categories)
                    .Where(m => m.Categories.Any(g => g.CategoryId == id));
            }

            if (!string.IsNullOrEmpty(q))//Search alanında girilecek metne göre filtreleme yapacak kod parçası.
            {
                books = books.Where(i =>
                    i.Name.ToLower().Contains(q.ToLower()) ||
                    i.Writer.ToLower().Contains(q.ToLower()));
            }

            var model = new BooksViewModel()
            {
                books = books.ToList()
            };

            return View("Book", model);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(_context.Books.Find(id));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {

            return View(_context.Books.Find(id));
        }

        [HttpPost]
        public IActionResult Edit(Book b)
        {

            _context.Books.Update(b);
            _context.SaveChanges();
            return RedirectToAction("Details", "Book", new { @id = b.BookId });
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book b)
        {
            _context.Books.Add(b);
            _context.SaveChanges();
            TempData["Message"] = $"{b.Name} isimli kitap eklendi";
            return RedirectToAction("List");
        }

        [HttpPost]
        public IActionResult Delete(int BookId, string Name)
        {
            var entity = _context.Books.Find(BookId);
            if (entity == null)
            {
                return RedirectToAction("Index");
            }
            _context.Books.Remove(entity);
            _context.SaveChanges();
            TempData["Message"] = $"{Name} isimli kitap silindi";
            return RedirectToAction("List");
        }
    }
}
