using AmazonBooks.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Jessica Kinghorn
//Amazon Books Project Start: February 11th 2022

namespace AmazonBooks2.Components
{
    public class CategoriesViewComponent : ViewComponent 
    {
		private IAmazonBooksRepository repo { get; set; }
		public CategoriesViewComponent(IAmazonBooksRepository temp)
		{ repo = temp; }
		public IViewComponentResult Invoke()
		{
			ViewBag.SelectCategory = RouteData?.Values["category"]; 

			var categories = repo.Books
			.Select(x => x.Category)
			.Distinct()
			.OrderBy(x => x);
			return View(categories);
		}
	}
}
