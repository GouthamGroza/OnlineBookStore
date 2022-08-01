using BookCatalog.Data.Interfaces;
using BookCatalog.Data.Repositories;
using BookCatalog.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace OnlineBookStore.Controllers
{
    public class BooksController : ApiController
    {
        public IBookRepository books;

        public BooksController(IBookRepository _books) 
        {
            books = _books;
        }


        // GET api/values
        public IEnumerable<BooksCatalog> GetAllBooks()
        {
           return books.GetBooks();

           
        }

        // GET api/values/5
        public IHttpActionResult Get(int id)
        {
            var book = books.GetBook(id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
            
        }

        // POST api/values
        public IHttpActionResult Post(BooksCatalog book)
        {
           var result = books.AddBook(book);
            if (result)
            {
                return Ok(book);
            }
            return BadRequest();
        }
        //// PUT api/values/5
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/values/5
        public IHttpActionResult Delete(int id)
        {
            var result = books.DeleteBook(id);
            if (result)
            {
               return Ok(books.GetBooks());
            }
            return NotFound();
        }
    }
}