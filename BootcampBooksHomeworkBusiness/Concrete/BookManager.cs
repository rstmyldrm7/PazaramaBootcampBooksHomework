using BootcampBooksHomeworkBusiness.Abstract;
using BootcampBooksHomeworkCore.Data;
using BootcampBooksHomeworkDTO.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BootcampBooksHomeworkBusiness.Concrete
{
    public class BookManager : IBookService
    {
        private readonly BookContext _context;
        public BookManager(BookContext context) //Constructorımızda context nesnemizi tanmımlıyoruz. 
        {
            _context = context;
        }

        public void CreateBook(Book b)
        {
            _context.Books.Add(b);
            _context.SaveChanges();
        }

        public void DeleteBook(int BookId, string Name)
        {
            var entity = _context.Books.Find(BookId);
            _context.Books.Remove(entity);
            _context.SaveChanges();
        }

        public Book Details(int id)
        {
            var book = _context.Books.Find(id);
            return book;
        }

        public Book EditBook(Book b)
        {
            _context.Books.Update(b);
            _context.SaveChanges();
            return b;
        }

        public List<Book> GetBooks()
        {
            var books = _context.Books.ToList();
            return books;
        }

        public List<Book> List(int? id, string q)
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

            List<Book> model = new List<Book>();
            model = books.ToList();
            
            return model;
        }
    }
}
