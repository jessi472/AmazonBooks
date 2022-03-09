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

        public void SaveBook(Book b)
        {
            context.SaveChanges();
        }

        public void CreateBook(Book b)
        {
            context.Add(b);
            context.SaveChanges();
        }

        public void DeleteBook(Book b)
        {
            context.Remove(b);
            context.SaveChanges();
        }
    }
}
