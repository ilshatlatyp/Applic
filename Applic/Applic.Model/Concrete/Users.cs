using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Applic.Model.Abstract;
using System.Data.Entity;

namespace Applic.Model.Concrete
{
    public class Users:IUsers
    {
                /// <summary>
        /// Поле. Набор корзин
        /// </summary>
        private DbSet<User> _userDbSet;

        ///// <summary>
        ///// Делегат. Представляет метод сохранения изменений списка 
        ///// </summary>
        //public delegate void SaveChangesDelegate();

        ///// <summary>
        ///// Делегат. Представляет метод сохранения изменений списка 
        ///// </summary>
        //private SaveChangesDelegate _saveChangesDelegate;

        /// <summary>
        /// Свойство. Задает и возвращает набор 
        /// </summary>
        public DbSet<User> UserDbSet
        {
            get
            {
                return _userDbSet;
            }
            set
            {
                _userDbSet = value;
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public Users(DbSet<User> userDbSet)//, SaveChangesDelegate saveChangesDelegat
        {
            _userDbSet = userDbSet;
           // _saveChangesDelegate = saveChangesDelegat;
        }

        /// <summary>
        /// Метод. Создать  
        /// </summary>
        public IUser Create()
        {
            IUser user;
            user = (IUser)new User();
            return user;
        }

        /// <summary>
        /// Метод. Добавить  в список
        /// </summary>
        public void Add(IUser user)
        {
            _userDbSet.Add((User)user);
           // SaveChanges();
        }

        /// <summary>
        /// Метод. Удалить  из списка
        /// </summary>
        public void Remove(IUser user)
        {
            _userDbSet.Remove((User)user);
          //  SaveChanges();
        }

        /// <summary>
        /// Метод. Получить по ИД
        /// </summary>
        public IUser GetUser(int Id)
        {
            return ((IUser)_userDbSet.Where(c => c.UserId == Id));
        }

        /// <summary>
        /// Метод. Удалить по ИД
        /// </summary>
        public void RemoveById(int Id)
        {
            IUser user;
            user = GetUser(Id);
            _userDbSet.Remove((User)user);
         //   SaveChanges();
        }

        ///// <summary>
        ///// Метод. Сохранить
        ///// </summary>
        //public void SaveChanges()
        //{
        //    _saveChangesDelegate();
        //}

        /// <summary>
        /// Метод. Получить массив 
        /// </summary>
        public IUser[] ToArray()
        {
            return (_userDbSet.ToArray<IUser>());
        }

        /// <summary>
        /// Метод. Получить спиок 
        /// </summary>
        public List<IUser> ToList()
        {
            return (_userDbSet.ToList<IUser>());
        }
    }
}
