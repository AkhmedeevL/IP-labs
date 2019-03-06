using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using WeBookShop.Service.Abstract;

namespace WeBookShop.Models
{
    [Serializable]
    public class Book : BaseEntity
    {
        [Required(ErrorMessage = "Введите имя автора")]
        [RegularExpression(@"^.{1,100}$", ErrorMessage = "Введите от 1 до 100 символов")]
        public string Author { get; set; }
        [Required(ErrorMessage = "Введите название книги")]
        [RegularExpression(@"^.{1,100}$", ErrorMessage = "Введите от 1 до 100 символов")]
        public string Name { get; set; }

        //public Category Category { get; set; }
        [Required(ErrorMessage = "Введите имя автора")]
        [RegularExpression(@"^.{1,250}$", ErrorMessage = "Введите от 1 до 250 символов")]
        public string Annotation { get; set; }
         
        public string[] PicPath { get; set; }


        [Required(ErrorMessage = "Введите цену")]
        [RegularExpression(@"^\d{1,10}",
    ErrorMessage = "Неверно введена сумма")]
        public double Price { get; set; }

 

    }
}