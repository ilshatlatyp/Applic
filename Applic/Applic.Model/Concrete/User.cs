using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Applic.Model.Interfaces;

namespace Applic.Model.Concrete
{
    public class User:IUser
    {
        /// <summary>
        /// Свойство. Идентификатор пользователя
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Свойство. ФИО
        /// </summary>
        public string FIO { get; set; }

        /// <summary>
        /// Свойство. Логин
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Свойство. Пароль
        /// </summary>
        public string Passw { get; set; }

        /// <summary>
        /// Свойство. Долг/аванс покупателя
        /// </summary>
        public int Account { get; set; }

        /// <summary>
        /// Свойство. Номер телефона
        /// </summary>
        public int PhoneNumber { get; set; }

        /// <summary>
        /// Свойство. Заказ
        /// </summary>
        public Cart Order { get; set; }

        /// <summary>
        /// Свойство. Права пользователя
        /// </summary>
        public string Role { get; set; }
    }
}
