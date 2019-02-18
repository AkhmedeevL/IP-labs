using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WeBookShop.Models;

namespace WeBookShop
{
    public class BookShopContext : DbContext
    {
        public DbSet <User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categorys { get; set; }
    }
}