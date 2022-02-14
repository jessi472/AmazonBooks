using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//Amazon Books Project Start: February 11th, 2022
namespace AmazonBooks.Models
{
    public class EFAmazonBooksRepository : IAmazonBooksRepository
    {

        private BookstoreContext context { get; set; }
        public EFAmazonBooksRepository (BookstoreContext temp)
        {
            context = temp;
        }
        public IQueryable<Book> Books => context.Books;
    }
}
