using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//Amazon Books Project Start: February 11th, 2022
namespace AmazonBooks.Models.ViewModels
{
    public class BookViewModel
    {
        public IQueryable<Book> Books { get; set; }
         public PageInfo PageInfo { get; set; }
    }
}
