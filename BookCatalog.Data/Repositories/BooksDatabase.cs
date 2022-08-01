using BookCatalog.Data.Interfaces;
using BookCatalog.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCatalog.Data.Repositories
{
    public class BooksDatabase : IBookRepository
    {
        private readonly BooksDbContext db;

        public BooksDatabase(BooksDbContext _db)
        {
            db = _db;
        }
        public bool AddBook(BooksCatalog book)
        {
            db.Books.Add(book);
            db.SaveChanges();
            return true;
        }

        public bool DeleteBook(int id)
        {
            var book = GetBook(id);
            if (book == null)
            {
                return false;
            }
            db.Books.Remove(book);
            db.SaveChanges();
            return true;
        }

        public BooksCatalog GetBook(int id)
        {
            return db.Books.FirstOrDefault(x => x.BookId == id);   
        }

        public List<BooksCatalog> GetBooks()
        {
            return db.Books.ToList();
        }
    }
}
