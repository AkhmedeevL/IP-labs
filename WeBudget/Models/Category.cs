using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WeBookShop.Service.Abstract;

namespace WeBookShop.Models
{
    [Serializable]
    public class Category : BaseEntity
    {
    

        public string Name { get; set; }


        // public  User User { get; set; }


    }
}