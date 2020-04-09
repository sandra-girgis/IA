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
        public ActionResult AddProduct( Product product,HttpPostedFileBase ImageFile)
         {

             if (ModelState.IsValid )
             {
                string fileName = Path.GetFileNameWithoutExtension(ImageFile.FileName);
                string extension = Path.GetExtension(ImageFile.FileName);
                fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                product.Image = "~/Image/" + fileName;
                fileName = Path.Combine(Server.MapPath("~/Image/"), fileName);
                int x = product.category_id;
                ImageFile.SaveAs(fileName);
                db.Products.Add(product);
                var Category = db.category.Find(x);
                Category.number_of_products += 1;
                db.SaveChanges();
                return View("Done");
             }

             else
             {
                 return View("creation_error");
             }
         }
        
        // GET: Customer/1
        public ActionResult Product(int id)
        {

            this.db = new DatabaseContext();
            var Product = db.Products.Find(id);
            if (Product == null)
            {
                return HttpNotFound();
            }
            return View(Product);
            
        }

    }
}




