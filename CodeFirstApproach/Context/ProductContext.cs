using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CodeFirstApproach.Models;

namespace CodeFirstApproach.Context
{
    public class ProductContext: DbContext
    {
        public DbSet<Category> Categories { get; set; }
        
        public DbSet<Product> products { get; set; }

    }
}