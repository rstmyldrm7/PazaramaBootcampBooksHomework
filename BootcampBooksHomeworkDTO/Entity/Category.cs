using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BootcampBooksHomeworkDTO.Entity
{
    public class Category : BaseEntity
    {
        public int CategoryId { get; set; }
        public List<Book> Movies { get; set; }
    }
}
