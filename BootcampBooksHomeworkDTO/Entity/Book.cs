using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BootcampBooksHomeworkDTO.Entity
{
    public class Book : BaseEntity
    {
        public int BookId { get; set; }
        public string Writer { get; set; }
        public string ImageUrl { get; set; }
        public List<Category> Categories { get; set; }
    }
}
