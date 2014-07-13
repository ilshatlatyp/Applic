using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Applic.Model.Abstract;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc; 

namespace Applic.Model.Concrete
{
    public class Product:IProduct
    {
        /// <summary>
        /// Свойство. Идентификатор продукта
        /// </summary>
        public int ProductId { get; set; }


        /// <summary>
        /// Свойство. Наименование товара
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// Свойство. Категория
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Свойство. Описание
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Свойство. Цена
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// Свойство. Список корзин, в которых есть товар
        /// </summary>
        public List<Cart> Carts { get; set; }

        /// <summary>
        /// Свойство. Изображение товара
        /// </summary>
        public byte[] ImageData { get; set; }

        /// <summary>
        /// Свойство. Тип фотографии
        /// </summary>
        [HiddenInput(DisplayValue = false)]
        public string ImageMimeType { get; set; } 
    }
}
