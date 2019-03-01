using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WeBookShop.Service.Abstract;

namespace WeBookShop.Models
{
    [Serializable]
    public class Book : BaseEntity
    {

        public string Author { get; set; }
        public string Name { get; set; }

        //public Category Category { get; set; }
         
        public string Annotation { get; set; }
         
        public string[] PicPath { get; set; }
         
        public double Price { get; set; }

 

    }
}