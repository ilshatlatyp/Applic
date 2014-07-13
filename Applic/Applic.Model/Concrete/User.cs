using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Applic.Model.Abstract;

namespace Applic.Model.Concrete
{
    public class User:IUser
    {
        /// <summary>
        /// Свойство. Идентификатор пользователя
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Свойство. ФИО пользователя
        /// </summary>
        public string FIO { get; set; }

        /// <summary>
        /// Свойство. Логин пользователя
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Свойство. Пароль пользователя
        /// </summary>
        public string Passw { get; set; }

        /// <summary>
        /// Свойство. Роль пользователя
        /// </summary>
        public string Role { get; set; }
    }
}
