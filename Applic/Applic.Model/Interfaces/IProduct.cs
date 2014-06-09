using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Applic.Model.Concrete;

namespace Applic.Model.Interfaces
{
   public interface IProduct
    {
        /// <summary>
        /// Свойство. Идентификатор товара
        /// </summary>
        int ProductId { get; set; }

        /// <summary>
        /// Свойство. Название товара
        /// </summary>
        string ProductName { get; set; }

        /// <summary>
        /// Свойство. Категория товара
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
    }
}
