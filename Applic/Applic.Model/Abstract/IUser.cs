using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Applic.Model.Concrete;

namespace Applic.Model.Abstract
{
   public interface IUser
    {
        /// <summary>
        /// Свойство. Идентификатор пользователя
        /// </summary>
        int UserId { get; set; }

        /// <summary>
        /// Свойство. ФИО пользователя
        /// </summary>
        string FIO { get; set; }

        /// <summary>
        /// Свойство. Логин пользователя
        /// </summary>
        string Login { get; set; }

        /// <summary>
        /// Свойство. Пароль пользователя
        /// </summary>
        string Passw { get; set; }

        /// <summary>
        /// Свойство. Роль пользователя
        /// </summary>
        string Role { get; set; }
    }
}
