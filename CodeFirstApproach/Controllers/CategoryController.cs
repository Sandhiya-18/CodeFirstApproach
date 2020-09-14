using CodeFirstApproach.Context;
using CodeFirstApproach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstApproach.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        private ProductContext context = new ProductContext();
        public ActionResult Index()
        {
            return View(context.Categories.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Category());
        }
        [HttpPost]
        public ActionResult Create(Category category)
        {
            if(ModelState.IsValid)
            {
                context.Categories.Add(category);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View(category);
            }

        }
     

    }
}