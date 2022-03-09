using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Jessica Kinghorn
//Amazon Books Project Start: February 11th 2022

namespace AmazonBooks2.Models
{
    public interface IOrderRepository
    {
        IQueryable<Order> Orders { get; }

        void SaveOrder(Order order);
    }
}
