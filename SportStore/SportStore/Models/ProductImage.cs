using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportStore.Models
{
    public class ProductImage
    {
        public int ID { get; set; }
        public string ImageUrl { get; set; }
        public int ProductID { get; set; }
    }
}