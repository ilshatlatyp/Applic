using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Applic.Model.Concrete;

namespace Applic.Model.Abstract
{
   public interface IProduct
    {
        /// <summary>
        /// Свойство. Идентификатор продукта
        /// </summary>
         int ProductId { get; set; }

         /// <summary>
         /// Свойство. Наименование товара
         /// </summary>
         string ProductName { get; set; }

         /// <summary>
         /// Свойство. Категория
         /// </summary>
         Category Category { get; set; }

         /// <summary>
         /// Свойство. Описание
         /// </summary>
         string Description { get; set; }

         /// <summary>
         /// Свойство. Цена
         /// </summary>
         int Price { get; set; }

         /// <summary>
         /// Свойство. Список корзин, в которых есть товар
         /// </summary>
         List<Cart> Carts { get; set; }

         /// <summary>
         /// Свойство. Изображение товара
         /// </summary>
         byte[] ImageData { get; set; }

         /// <summary>
         /// Свойство. Тип фотографии
         /// </summary>
         string ImageMimeType { get; set; } 
    }
}
