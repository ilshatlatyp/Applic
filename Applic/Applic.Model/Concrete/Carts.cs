using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Applic.Model.Abstract;

namespace Applic.Model.Concrete
{
    public class Carts:ICarts
    {   
        /// <summary>
        /// Поле. Набор корзин
        /// </summary>
        private DbSet<Cart> _cartDbSet;

        /// <summary>
        /// Делегат. Представляет метод сохранения изменений списка корзин
        /// </summary>
       // public delegate void SaveChangesDelegate();

        /// <summary>
        /// Делегат. Представляет метод сохранения изменений списка корзин
        /// </summary>
       // private SaveChangesDelegate _saveChangesDelegate;

        /// <summary>
        /// Свойство. Задает и возвращает набор корзин
        /// </summary>
        public DbSet<Cart> CartDbSet
        {
            get
            {
                return _cartDbSet;
            }
            set
            {
                _cartDbSet = value;
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public Carts(DbSet<Cart> cartDbSet)//, SaveChangesDelegate saveChangesDelegat
        {
            _cartDbSet = cartDbSet;
           // _saveChangesDelegate = saveChangesDelegat;
        }

        /// <summary>
        /// Метод. Создать корзину 
        /// </summary>
        public ICart Create()
        {
            ICart cart;
            cart = (ICart) new Cart();
            return cart;
        }

        /// <summary>
        /// Метод. Добавить корзину в список
        /// </summary>
        public void Add(ICart cart)
        {
            _cartDbSet.Add((Cart)cart);
           // SaveChanges();
        }

        /// <summary>
        /// Метод. Удалить корзину из списка
        /// </summary>
        public void Remove(ICart cart)
        {
            _cartDbSet.Remove((Cart)cart);
          //  SaveChanges();
        }

        /// <summary>
        /// Метод. Получить корзину по ИД
        /// </summary>
        public ICart GetCart(int Id)
        {
            return ((ICart)_cartDbSet.Where(c => c.CartId == Id));
        }

        /// <summary>
        /// Метод. Удалить по ИД
        /// </summary>
        public void RemoveById(int Id)
        {
            ICart cart;
            cart = GetCart(Id);
            _cartDbSet.Remove((Cart)cart);
           // SaveChanges();
        }

        /// <summary>
        /// Метод. Сохранить
        /// </summary>
        //public void SaveChanges()
        //{
        //    _saveChangesDelegate();
        //}

        /// <summary>
        /// Метод. Получить массив тележек
        /// </summary>
        public ICart[] ToArray()
        {
            return (_cartDbSet.ToArray<ICart>());
        }

        /// <summary>
        /// Метод. Получить спиок корзин
        /// </summary>
        public List<ICart> ToList()
        {
            return (_cartDbSet.ToList<ICart>());
        }
    }
}
