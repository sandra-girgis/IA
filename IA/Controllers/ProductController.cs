using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IA.Models;
using System.Data.Entity;
using IA.Context;

namespace IA.Controllers
{
    public class ProductController : Controller
    {
        private DatabaseContext db = new DatabaseContext();
        // GET: Product
        [HttpGet]
        public ActionResult AddProduct()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        //public ActionResult addition()
        //{

        // }
        public ActionResult Creation(Product product)
        {
            
            if (ModelState.IsValid)
            {
                
                db.Products.Add(product);
                db.SaveChanges();
                return View("Done");
            }
            else
                return View("Error");
        }
        
       
    }
}