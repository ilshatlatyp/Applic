using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Applic.Model.Concrete;

namespace Applic.Model.Abstract
{
    public interface ICart
    {
        /// <summary>
        /// Свойство. Идентификатор корзины
        /// </summary>
         int CartId { get; set; }

         /// <summary>
         /// Свойство. Список товаров в корзине
         /// </summary>
         List<Product> Products { get; set; }

         /// <summary>
         /// Свойство. Пользователь, которому принадлежит корзина
         /// </summary>
         User User { get; set; }

         /// <summary>
         /// Метод. Добавить продукт в корзину
         /// </summary>
         void AddProduct(Product product, int Quantity);

         /// <summary>
         /// Метод. Удалить продукт из корзину
         /// </summary>
         void Remove(Product product);

         /// <summary>
         /// Метод. Подсчитать итоги
         /// </summary>
         int ComputeTotal();

         /// <summary>
         /// Метод. Получить список корзин
         /// </summary>
         IEnumerable<CartLine> GetEnum { get; }
    }
}
