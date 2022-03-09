using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//Amazon Books Project Start: February 11th, 2022
namespace AmazonBooks.Models
{
    public interface IAmazonBooksRepository
    {
        IQueryable<Book> Books { get; }

        public void SaveBook(Book b);

        public void CreateBook(Book b);

        public void DeleteBook(Book b);
    }
}
