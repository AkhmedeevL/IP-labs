using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WeBookShop.Models;
using WeBookShop.Service.Abstract;

namespace WeBookShop.Service
{
	public class BookService : IBookShop
	{
		BookShopContext db = new BookShopContext();
		public  void Delete(int id) {
            Book b = db.Books.Find(id);
            if (b != null)
            {
                db.Books.Remove(b);
                db.SaveChanges();
            }
        }

        public void Edit(BaseEntity baseEntity) {
            db.Entry((Book)baseEntity).State = EntityState.Modified;
            db.SaveChanges();
        }

        public  void Create(BaseEntity baseEntity) {
            db.Books.Add((Book)baseEntity);
            db.SaveChanges();
        }

        public BaseEntity findById(int? id)
        {
            Book Book = db.Books.Find(id);
            return Book;
        }

        public  List<BaseEntity> getList()
        {

            return db.Books.ToList<BaseEntity>();
        }
        public List<BaseEntity> GetBook(string SearchAuthor)
        {
            var result = db.Books.Where(x => x.Author == SearchAuthor).ToList<BaseEntity>();
            return result;
            //  var result = db.Diaries.Where(x => x.SchoolId.Contains(searchingSchool) || searchingSchool == null).ToList();
        }



    }
}