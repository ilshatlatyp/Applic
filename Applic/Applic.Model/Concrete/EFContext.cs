using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Applic.Model.Concrete;

namespace Applic.Model.Concrete
{
    public class EFContext:DbContext
    {
        /// <summary>
        /// Свойство. Таблица продукты
        /// </summary>
        public DbSet<Product> EProduct { get; set; }
        
        /// <summary>
        /// Свойство. Таблица Пользователи
        /// </summary>
        public DbSet<User> EUser { get; set; }

        /// <summary>
        /// Свойство. Таблица Категории
        /// </summary>
        public DbSet<Category> ECategory { get; set; }

        /// <summary>
        /// Свойство. Таблица корзины
        /// </summary>
        public DbSet<Cart> ECart { get; set; }

    }
}
