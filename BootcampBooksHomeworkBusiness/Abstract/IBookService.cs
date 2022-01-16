using BootcampBooksHomeworkDTO.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootcampBooksHomeworkBusiness.Abstract
{
    public interface IBookService
    {
        List<Book> GetBooks();
        void CreateBook(Book b);
        Book Details(int id);

        Book EditBook(Book b);
        void DeleteBook(int BookId, string Name);
        List<Book> List(int? id, string q);

    }
}
