using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Applic.Model.Abstract;

namespace Applic.Model.Concrete
{
    public class Cart:ICart
    {
        /// <summary>
        /// Свойство. Идентификатор корзины
        /// </summary>
        public int CartId { get; set; }

        /// <summary>
        /// Свойство. Список товаров в корзине
        /// </summary>
        public List<Product> Products { get; set; }

        /// <summary>
        /// Свойство. Пользователь, которому принадлежит корзина
        /// </summary>
        public User User { get; set; }

        private List<CartLine> lineCollection = new List<CartLine>();

        /// <summary>
        /// Метод. Добавить продукт в корзину
        /// </summary>
        public void AddProduct(Product product, int Quantity)
        {
            CartLine line = lineCollection.Where(p => p.Product.ProductId == product.ProductId).FirstOrDefault();
            if (line == null)
            {
                lineCollection.Add(new CartLine{Product = product, Quantity= Quantity});
            }
            else
            {
                line.Quantity += Quantity;
            }
        }


        /// <summary>
        /// Метод. Удалить продукт из корзину
        /// </summary>
        public void Remove(Product product)
        {
            lineCollection.RemoveAll(p => p.Product.ProductId == product.ProductId);
        }

        /// <summary>
        /// Метод. Подсчитать итоги
        /// </summary>
        public int ComputeTotal()
        {
            return lineCollection.Sum(p=>p.Product.Price*p.Quantity);
        }

        /// <summary>
        /// Метод. Получить список корзин
        /// </summary>
        public IEnumerable<CartLine> GetEnum
        {
            get { return lineCollection; }
        }
    }

   
    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
