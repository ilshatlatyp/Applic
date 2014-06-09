using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Applic.Model.Concrete;

namespace Applic.Model.Interfaces
{
   public  interface IUser
    {
        /// <summary>
        /// Свойство. Идентификатор пользователя
        /// </summary>
         int UserId { get; set; }

         /// <summary>
         /// Свойство. ФИО
         /// </summary>
         string FIO { get; set; }

         /// <summary>
         /// Свойство. Логин
         /// </summary>
         string Login { get; set; }

         /// <summary>
         /// Свойство. Пароль
         /// </summary>
         string Passw { get; set; }

         /// <summary>
         /// Свойство. Долг/аванс покупателя
         /// </summary>
         int Account { get; set; }

         /// <summary>
         /// Свойство. Номер телефона
         /// </summary>
         int PhoneNumber { get; set; }

         /// <summary>
         /// Свойство. Заказ
         /// </summary>
         Cart Order { get; set; }

         /// <summary>
         /// Свойство. Права пользователя
         /// </summary>
         string Role { get; set; }
    }
}
