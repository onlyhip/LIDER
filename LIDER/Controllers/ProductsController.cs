using LIDER.Models;
using LIDER.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LIDER.Controllers
{
    public class ProductsController : Controller
    {
        private ApplicationDbContext _dbContext;
        public ProductsController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewAll()
        {
            var getcategory = _dbContext.Categories
                .ToList();

            var getproduct = _dbContext.Products
                .ToList();
            var viewModel = new GetView
            {
                Categories = getcategory,
                Products = getproduct
            };
            return View(viewModel);
        }

    }
}