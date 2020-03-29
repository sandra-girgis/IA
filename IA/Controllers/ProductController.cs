using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IA.Models;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
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
        public ActionResult creation( Product product, HttpPostedFileBase Image)
         {

             if (ModelState.IsValid )
             {
                     db.Products.Add(product);
                     db.SaveChanges();
                     return View("Done");
             }

             else
             {
                 return View("creation_error");
             }
         }
         
    }
}




