using BookCatalog.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCatalog.Data.Interfaces
{
    public interface IBookRepository
    {
        List<BooksCatalog> GetBooks();
        BooksCatalog GetBook(int id);    

        bool AddBook(BooksCatalog book);
        bool DeleteBook(int id);


    }
}
