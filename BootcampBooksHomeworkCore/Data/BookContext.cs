using BootcampBooksHomeworkDTO.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootcampBooksHomeworkCore.Data
{
    public class BookContext : DbContext //Context dosyasında CodeFirst esnasıdna oluşacak DB tabloları tanımlamaları için oluşturuyoruz. 
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
