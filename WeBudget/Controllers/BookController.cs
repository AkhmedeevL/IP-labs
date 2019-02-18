using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeBookShop.Models;
using WeBookShop.Service;
using WeBookShop.Service.Abstract;
using WeBookShop.Service.FileService;

namespace WeBookShop.Controllers
{
    public class BookController : Controller
    {
       String store = ConfigurationManager.AppSettings.Get("Store");
       IBookShop Bookservice;
      

        public BookController() {
            if (store == "db")
            {
              Bookservice = new BookService();
            }

            if (store == "file")
            {
              Bookservice = new BookFileService();
            }
        }

        [HttpGet]
        public ActionResult EditBook(int? id)
        {

            if (Bookservice.findById(id) != null)
            {
                return View(Bookservice.findById(id));
            }
            return HttpNotFound();
        }

        [HttpPost]
        public ActionResult EditBook(Book Book)
        {
            Bookservice.Edit(Book);
            return RedirectToAction("Books");
        }

        [HttpGet]
        public ActionResult CreateBook()

        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateBook(Book Book)
        {
            Bookservice.Create(Book);
            return RedirectToAction("Books");
        }

        public ActionResult DeleteBook(int id)
        {
            Bookservice.Delete(id);
            return RedirectToAction("Books");
        }

        public ActionResult Books()
        {
            return View(Bookservice.getList());
        }
    }
}