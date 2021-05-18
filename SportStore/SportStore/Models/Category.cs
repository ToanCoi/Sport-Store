using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportStore.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int SportID { get; set; }
    }
}