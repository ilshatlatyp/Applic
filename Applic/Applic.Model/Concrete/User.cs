using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applic.Model.Concrete
{
    public class User
    {
        public int UserId { get; set; }
        public string FIO { get; set; }
        public string Login { get; set; }
        public string Passw { get; set; }
        public Cart Order { get; set; }
        public Role Role { get; set; }
    }
}
