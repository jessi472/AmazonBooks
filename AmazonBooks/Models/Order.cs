using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AmazonBooks2.Models
{
    public class Order
    {
        [Key]
        [BindNever]
        public int OrderId { get; set; }

        [BindNever]
        public ICollection<BasketLineItem> Lines { get; set; }

        [Required(ErrorMessage = "Please Enter a name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter a valid address")]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }


        [Required(ErrorMessage = "Please Enter a city")]
        public string City { get; set; }


        [Required(ErrorMessage = "Please Enter a state")]
        public string State { get; set; }

        public string Zipcode { get; set; }


        [Required(ErrorMessage = "Please Enter a country")]
        public string Country { get; set;}

        public bool Gift { get; set; }
    }
}
