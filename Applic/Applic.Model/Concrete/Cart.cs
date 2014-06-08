using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applic.Model.Concrete
{
    public class Cart
    {
        public int CartId { get; set; }
        public List<Product> Products { get; set; }
    }
}
