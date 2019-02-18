using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WeBookShop.Models;
using WeBookShop.Service.Abstract;

namespace WeBookShop.Service
{
	public class CategoryService : IBookShop
	{
        BookShopContext db = new BookShopContext();
        public  void Delete(int id)
        {
            Category b = db.Categorys.Find(id);
            if (b != null)
            {
                db.Categorys.Remove(b);
                db.SaveChanges();
            }
        }

        public  void Edit (BaseEntity baseEntity)
        {
            db.Entry((Category)baseEntity).State = EntityState.Modified;
            db.SaveChanges();
        }

        public  void Create(BaseEntity baseEntity)
        {
            db.Categorys.Add((Category)baseEntity);
            db.SaveChanges();
        }

        public  BaseEntity findById(int? id)
        {
            Category Category = db.Categorys.Find(id);
            return Category;
        }

        public  List<BaseEntity> getList()
        {
            return db.Categorys.ToList<BaseEntity>();

        }

       
    }
}
