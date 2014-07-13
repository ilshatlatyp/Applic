using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applic.Model.Concrete
{
    public class Category
    {
        /// <summary>
        /// Свойство. Идентификатор категории
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Свойство. Наименование категории
        /// </summary>
        public string CategoryName { get; set; }
    }
}
