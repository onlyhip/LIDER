using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LIDER.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public string Meta { get; set; }
        public bool Hide { get; set; }
        public int Ranking {get;set;}
        public ICollection<Product> Product { get; set; }

    }
}