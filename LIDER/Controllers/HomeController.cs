using LIDER.Models;
using LIDER.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LIDER.Controllers
{

    public class HomeController : Controller
    {
        private ApplicationDbContext _dbContext;
        public HomeController()
        {
            _dbContext = new ApplicationDbContext();
        }

        public ActionResult Index()
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



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}