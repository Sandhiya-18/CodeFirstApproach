using CodeFirstApproach.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstApproach.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            ProductContext context = new ProductContext();
            var products = context.products.ToList();
            return View(products);
        }
    }
}