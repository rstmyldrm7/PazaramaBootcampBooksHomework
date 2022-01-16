using BootcampBooksHomeworkDTO.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootcampBooksHomeworkBusiness.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
    }
}
