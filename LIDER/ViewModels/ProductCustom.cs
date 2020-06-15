using LIDER.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LIDER.ViewModels
{
    public class ProductCustom
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public string Img { get; set; }
        public string Description { get; set; }
        public string Meta { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public bool Hide { get; set; }
        public int Ranking { get; set; }
        public int CategoryID { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}