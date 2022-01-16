using BootcampBooksHomeworkBusiness.Abstract;
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

        private readonly ICategoryService _categoryService;
        public CategoriesViewComponent(ICategoryService categoryService) //Constructorımızda context nesnemizi tanmımlıyoruz. 
        {
            _categoryService = categoryService;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedGenre = RouteData.Values["id"];
            return View(_categoryService.GetCategories().ToList());
        }
    }
}
