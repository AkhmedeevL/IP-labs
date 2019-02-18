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
    public class CategoryController : Controller
    {
        String store = ConfigurationManager.AppSettings.Get("Store");
        IBookShop Categoryservice;


        public CategoryController()
        {
            if (store == "db")
            {
                Categoryservice = new CategoryService();
            }

            if (store == "file")
            {
                Categoryservice = new CategoryFileService();
            }
        }
      

        [HttpGet]
        public ActionResult EditCategory(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            
            if (Categoryservice.findById(id) != null)
            {
                return View(Categoryservice.findById(id));
            }
            return HttpNotFound();
        }

        [HttpPost]
        public ActionResult EditCategory(Category Category)

        {
            Categoryservice.Edit(Category);
            return RedirectToAction("Categorys");
        }

        [HttpGet]
        public ActionResult CreateCategory()

        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCategory(Category Category)
        {
            Categoryservice.Create(Category);
            return RedirectToAction("Categorys");
        }


        public ActionResult DeleteCategory(int id)
        {
            Categoryservice.Delete(id);
            return RedirectToAction("Categorys");
        }


        public ActionResult Categorys()
        {          
             return View(Categoryservice.getList());
           
        }
       
    }
}