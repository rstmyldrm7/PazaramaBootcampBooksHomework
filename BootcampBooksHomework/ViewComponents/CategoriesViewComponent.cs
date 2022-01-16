using BootcampBooksHomeworkCore.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootcampMovieApp.ViewComponents
{
    public class CategoriesViewComponent : ViewComponent
    {

        private readonly BookContext _context;
        public CategoriesViewComponent(BookContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedGenre = RouteData.Values["id"];
            return View(_context.Categories.ToList());
        }
    }
}
