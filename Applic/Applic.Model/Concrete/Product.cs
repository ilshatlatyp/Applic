using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Applic.Model.Interfaces;

namespace Applic.Model.Concrete
{
    public class Product:IProduct
    {
        /// <summary>
        /// Свойство. Идентификатор товара
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// Свойство. Название товара
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        /// Свойство. Категория товара
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
    }
}
