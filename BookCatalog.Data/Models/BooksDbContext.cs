using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCatalog.Data.Models
{
    public class BooksDbContext : DbContext
    {
        public BooksDbContext() : base("name = BooksDbContext")
        {

        }

        public DbSet<BookCatalog.Data.Models.BooksCatalog> Books { get; set; }
    }
}
