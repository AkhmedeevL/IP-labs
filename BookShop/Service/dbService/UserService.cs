using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WeBookShop.Models;

namespace WeBookShop.Service
{
    public class UserService
    {
        BookShopContext db = new BookShopContext();

        public void Create(User User) {
            db.Users.Add(User);
            db.SaveChanges();
        }

        public List<User> getList()
        {
            return db.Users.ToList();

        }

        public void Dispose()
        {
            db.Dispose();
        }

    }
}