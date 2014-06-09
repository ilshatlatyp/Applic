using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Applic.Model.Concrete;

namespace Applic.Model.Interfaces
{
   public interface ICart
    {
       /// <summary>
       /// Свойство. Идентификатор корзины
       /// </summary>
       int CartId { get; set; }

       /// <summary>
       /// Свойство. Список покупок
       /// </summary>
       List<Product> Products { get; set; }
    }
}
