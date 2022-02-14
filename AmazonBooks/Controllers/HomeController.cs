using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmazonBooks.Models;
using Microsoft.AspNetCore.Mvc;
using AmazonBooks.Models.ViewModels;


//Amazon Books Project Start: February 11th, 2022
namespace AmazonBooks.Controllers
{
    public class HomeController : Controller
    {
        private IAmazonBooksRepository repo;
        public HomeController (IAmazonBooksRepository temp)
        {
            repo = temp;
        }

        //Create each page of books
        public IActionResult Index(int pageNum = 1)
        {
            int pageSize = 10;
            var books = new BookViewModel
            {
              Books = repo.Books
            .OrderBy(b => b.Title)
            .Skip((pageNum-1 )* pageSize)
            .Take(pageSize),

            PageInfo = new PageInfo
                {
                    TotalNumBooks = repo.Books.Count(),
                    BooksPerPage = pageSize,
                    CurrentPage = pageNum
                }
            };
                
            return View(books);
        }
    }
}
