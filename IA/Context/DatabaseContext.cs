using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using IA.Models;

namespace IA.Context
{
    public class DatabaseContext: DbContext
    {
        public DbSet<Category> category { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}