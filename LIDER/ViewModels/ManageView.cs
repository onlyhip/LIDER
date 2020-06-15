using LIDER.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LIDER.ViewModels
{
    public class ManageView
    {
        public IEnumerable<Product> ManageProd { get; set; }
        public Product ProdDetails { get; set; }
        public IEnumerable<Category> Categories { get; set; }

    }
}