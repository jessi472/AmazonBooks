using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmazonBooks.Models;
using AmazonBooks2.Infrastructures;
using AmazonBooks2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

//Jessica Kinghorn
//Amazon Books Project Start: February 11th 2022

namespace AmazonBooks2.Pages
{
    public class BuyBookModel : PageModel
    {
        private IAmazonBooksRepository repo { get; set; }

        public BuyBookModel (IAmazonBooksRepository temp, Basket b)
        {
            repo = temp;
            basket = b;
        }

        public Basket basket { get; set; }

        public string ReturnUrl { get; set; }

        public void OnGet(Basket b, string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            //basket = HttpContext.Session.GetJson<Basket>("basket") ?? new Basket();
        }

        public IActionResult OnPost(int bookId, string returnUrl)
        {
            Book b = repo.Books.FirstOrDefault(x => x.BookId == bookId);
            //basket = new Basket();
            //basket = HttpContext.Session.GetJson<Basket>("basket") ?? new Basket();
            basket.AddItem(b, 1);
            //HttpContext.Session.SetJson("basket", basket);
            return RedirectToPage(new { ReturnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(int bookId, string returnUrl)
        {
            basket.RemoveItem(basket.Items.First(x => x.Book.BookId == bookId).Book);
            return RedirectToPage(new { ReturnUrl = returnUrl });
        }
    }
}
