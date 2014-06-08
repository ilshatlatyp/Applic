using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

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


    }
}
