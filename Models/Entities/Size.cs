using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMST4.Store.Shoes.Models.Entities
{
    public class Size
    {
        public Guid Id { get; set;}
        public string Description { get; set;}
        public DateTime CreateBy { get; set;}
    }
}