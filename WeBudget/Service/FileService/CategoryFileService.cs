using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Xml.Serialization;
using WeBookShop.Models;
using WeBookShop.Service.Abstract;

namespace WeBookShop.Service.FileService
{
    public class CategoryFileService : AbstractClass
    {
        string Name = "Category";
        string currentPath = HttpContext.Current.Server.MapPath("~") + "/Files/Category";
        XmlSerializer xsSubmit = new XmlSerializer(typeof(Category));

        public CategoryFileService()
        {
            base.Name = Name;
            base.xsSubmit = xsSubmit;
            base.currentPath = currentPath;
        }

    }
}