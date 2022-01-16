using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BootcampBooksHomeworkDTO.Entity
{
    public class BaseEntity
    {
        [Required]
        public string Name { get; set; }
    }
}
