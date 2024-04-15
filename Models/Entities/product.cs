using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMST4.Store.Shoes.Models.Entities
{

    public class Product
    {
        public string Description { get; set;}
        public Guid Color { get; set; }
        public Guid Id { get; set; }
        public double Price { get; set; }
        public double Stock { get; set; }
        public bool IsActive { get; set; }
    }
}