using LIDER.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LIDER.ViewModels
{
    public class GetView
    {
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Product> Prod { get; set; }
        public string CurrentPage { get; set; }
    }
}