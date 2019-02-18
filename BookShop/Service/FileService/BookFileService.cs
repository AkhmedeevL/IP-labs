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
    public class BookFileService: AbstractClass
    {
        string Name = "Book";
        string currentPath = HttpContext.Current.Server.MapPath("~") + "/Files/Book";
        XmlSerializer xsSubmit = new XmlSerializer(typeof(Book));

        public BookFileService()
        {
            base.Name = Name;
            base.xsSubmit = xsSubmit;
            base.currentPath = currentPath;
        }
}
}