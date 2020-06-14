using LIDER.Models;
using LIDER.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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

        public ActionResult Categories(string id)
        {

            var getcategory = _dbContext.Categories
               .ToList();

            var getprod = _dbContext.Products
                .ToList();

            var getproduct = _dbContext.Products
                .ToList(); 
            
            if (id == "View-All")
            {
                getproduct = _dbContext.Products
                .ToList();
            }
            else
            {
                getproduct = _dbContext.Products
                .Where(a => a.Category.Name == id)
                .ToList();
            }
            string currentpage = id;

            var viewModel = new GetView
            {
                Categories = getcategory,
                Products = getproduct,
                Prod = getprod,
                CurrentPage = currentpage
            };
            return View(viewModel);
        }

        public ActionResult Details(int? id)
        {
            var getcategory = _dbContext.Categories
              .ToList();
            var getpro = _dbContext.Products
                .Where(a => a.ProductID == id)
                .ToList();
            var getproduct = _dbContext.Products
                .ToList();
            if (getpro == null)
            {
                return HttpNotFound();
            }
            var viewModel = new GetView
            {

                Categories = getcategory,
                Products = getproduct,
                Pro = getpro
            };
            return View(viewModel);
        }

    }
}