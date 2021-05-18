using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportStore.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public string Gender { get; set; }
        public bool IsFeatured { get; set; }
        public int CategoryId { get; set; }
        public int BrandID { get; set; }
    }
}