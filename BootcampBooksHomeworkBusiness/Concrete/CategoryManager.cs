using BootcampBooksHomeworkBusiness.Abstract;
using BootcampBooksHomeworkCore.Data;
using BootcampBooksHomeworkDTO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BootcampBooksHomeworkBusiness.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly BookContext _context;
        public CategoryManager(BookContext context)
        {
            _context = context;
        }
        public List<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }
    }
}
