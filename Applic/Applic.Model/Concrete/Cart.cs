using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Applic.Model.Interfaces;

namespace Applic.Model.Concrete
{
    public class Cart:ICart
    {
        /// <summary>
        /// Свойство. Идентификатор корзины
        /// </summary>
        public int CartId { get; set; }

        /// <summary>
        /// Свойство. Список покупок
        /// </summary>
        public List<Product> Products { get; set; }
    }
}
