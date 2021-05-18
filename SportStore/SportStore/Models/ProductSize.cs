using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportStore.Models
{
    public class ProductSize
    {
        public int ID { get; set; }
        public int Amount { get; set; }
        public int ProductID { get; set; }
        public int SizeID { get; set; }
    }
}