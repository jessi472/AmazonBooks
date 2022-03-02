using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmazonBooks2.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Checkout()
        {
            return View(new OrderBooks());
        }
    }
}
