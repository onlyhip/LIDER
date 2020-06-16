using LIDER.Models;
using LIDER.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Data.Entity.Migrations;

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

        [Authorize(Roles = "Admin")]
        public ActionResult ManageProducts()
        {
            if (!ModelState.IsValid)
            {
                return View("ManageProducts");
            }

            var getproduct = _dbContext.Products
               .Include(a => a.Category);

            var viewModel = new ManageView
            {
                ManageProd = getproduct
            };

            return View(viewModel);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult CreateProducts()
        {
            var viewModel = new ProductCustom
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View(viewModel);

        }


        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("CreateProducts")]
        [ValidateAntiForgeryToken]
        public ActionResult CreateProducts(ProductCustom prod)
        {
            if (!ModelState.IsValid)
            {
                prod.Categories = _dbContext.Categories.ToList();
                return View("CreateProducts", prod);
            }

            var pd = new Product
            {
                Name = prod.Name,
                Price = prod.Price,
                Img = prod.Img,
                Description = prod.Description,
                Meta = prod.Meta,
                Size = prod.Size,

                Color = prod.Color,
                Hide = prod.Hide,
                Ranking = prod.Ranking,
                CategoryID = prod.CategoryID
            };
            _dbContext.Products.Add(pd);
            _dbContext.SaveChanges();
            return RedirectToAction("ManageProducts", "Products");
        }

        [Authorize(Roles = "Admin")]
        public ActionResult DetailsProducts(int? id)
        {
            if (!ModelState.IsValid)
            {
                return View("DetailsProducts");
            }
            var getproduct = _dbContext.Products
             .Include(a => a.Category)
             .Where(c => c.ProductID == id);

            if (getproduct == null)
            {
                return HttpNotFound();
            }

            var viewModel = new ManageView
            {
                ProdDetails = getproduct.First()
            };

            return View(viewModel);
        }
        [Authorize(Roles = "Admin")]
        public ActionResult EditProducts(int? id)
        {
            if (!ModelState.IsValid)
            {
                return View("EditProducts");
            }
            var getproduct = _dbContext.Products
             .Include(a => a.Category)
             .Where(c => c.ProductID == id);

            if (getproduct == null)
            {
                return HttpNotFound();
            }

            var viewModel = new ManageView
            {
                Categories = _dbContext.Categories.ToList(),
                ProdDetails = getproduct.First()
            };
            return View(viewModel);
        }


        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditProducts(ManageView mv)
        {
            if (!ModelState.IsValid)
            {
                mv.Categories = _dbContext.Categories.ToList();
                return View("EditProducts", mv);
            }
            var pd = new Product
            {
                ProductID = mv.ProdDetails.ProductID,
                Name = mv.ProdDetails.Name,
                Price = mv.ProdDetails.Price,
                Img = mv.ProdDetails.Img,
                Description = mv.ProdDetails.Description,
                Meta = mv.ProdDetails.Meta,
                Size = mv.ProdDetails.Size,
                Color = mv.ProdDetails.Color,
                Hide = mv.ProdDetails.Hide,
                Ranking = mv.ProdDetails.Ranking,
                CategoryID = mv.ProdDetails.CategoryID
            };

            _dbContext.Products.AddOrUpdate(pd);
            _dbContext.SaveChanges();
            return RedirectToAction("ManageProducts", "Products");
        }

        [Authorize(Roles = "Admin")]
        public ActionResult DeleteProducts(int? id)
        {
            if (!ModelState.IsValid)
            {
                return View("DeleteProducts");
            }
            var getproduct = _dbContext.Products
             .Include(a => a.Category)
             .Where(c => c.ProductID == id);

            if (getproduct == null)
            {
                return HttpNotFound();
            }

            var viewModel = new ManageView
            {
                Categories = _dbContext.Categories.ToList(),
                ProdDetails = getproduct.First()
            };
            return View(viewModel);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteProducts(ManageView mv)
        {
            if (!ModelState.IsValid)
            {
                mv.Categories = _dbContext.Categories.ToList();
                return View("DeleteProducts", mv);
            }
            var pd = new Product
            {
                ProductID = mv.ProdDetails.ProductID
            };
            _dbContext.Products.Attach(pd);
            _dbContext.Products.Remove(pd);
            _dbContext.SaveChanges();
            return RedirectToAction("ManageProducts", "Products");
        }

    }
}