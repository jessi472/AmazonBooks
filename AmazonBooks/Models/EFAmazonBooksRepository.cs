using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
