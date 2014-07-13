using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Applic.Model.Concrete;

namespace Applic.Model.Abstract
{
   public interface IUsers
    {
        /// <summary>
        /// Свойство. Задает и возвращает набор пользователей
        /// </summary>
        DbSet<User> UserDbSet { get; set; }

        /// <summary>
        /// Метод. Создает пользователя
        /// </summary>
        IUser Create();

        /// <summary>
        /// Метод. Получить пользователя по идентификатору
        /// </summary>
        IUser GetUser(int Id);

        /// <summary>
        /// Метод. Добавить пользователя в список
        /// </summary>
        void Add(IUser user);

        /// <summary>
        /// Метод. Удалить пользователя из списка
        /// </summary>
        void Remove(IUser user);

        /// <summary>
        /// Метод.  Удалить  по идентификатору
        /// </summary>
        void RemoveById(int Id);

        ///// <summary>
        ///// Метод. Сохранить изменения
        ///// </summary>
        //void SaveChanges();

        /// <summary>
        /// Метод. Получить  массив
        /// </summary>
        IUser[] ToArray();

        /// <summary>
        /// Метод.  Привести к списку
        /// </summary>
        List<IUser> ToList();
    }
}
