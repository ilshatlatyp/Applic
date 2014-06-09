using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Applic.Model.Interfaces;

namespace Applic.Model.Concrete
{
    public class Carts
    {
        /// <summary>
        /// Поле. Набор корзин
        /// </summary>
        private DbSet<Cart> _cartDbSet;

        /// <summary>
        /// Свойство. Задает и возвращает набор корзин
        /// </summary>
        public DbSet<Cart> CartDbSet
        {
            get
            {
                return _cartDbSet;
            }
            set
            {
                _cartDbSet = value;
            }
        }

        /// <summary>
        /// Метод. Создает и возвращает новый корзину
        /// </summary>
        public ICart Create()
        {
            ICart cart;
            cart = (ICart)new Cart();

            return cart;
        }

        /// <summary>
        /// Метод. Добавляет новую корзину
        /// </summary>
        public void Add(ICart cart)
        {
            _cartDbSet.Add((Cart)cart);
            //saveChangesDelegat
        }

        /// <summary>
        /// Метод. Удаляет корзину
        /// </summary>
        public void Remove(ICart cart)
        {
            _cartDbSet.Remove((Cart)cart);
        }

    }
}
