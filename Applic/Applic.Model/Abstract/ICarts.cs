using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Applic.Model.Concrete;

namespace Applic.Model.Abstract
{
    public interface ICarts 
    {
        /// <summary>
        /// Свойство. Задает и возвращает набор корзин
        /// </summary>
        DbSet<Cart> CartDbSet { get; set; }

        /// <summary>
        /// Метод. Создает корзину
        /// </summary>
        ICart Create();

        /// <summary>
        /// Метод. Получить корзину по ИД
        /// </summary>
        ICart GetCart(int Id);

        /// <summary>
        /// Метод. Добавить корзину в список
        /// </summary>
        void Add(ICart cart);

        /// <summary>
        /// Метод. Удалить корзину из списка
        /// </summary>
        void Remove(ICart cart);

        /// <summary>
        /// Метод. Удалить по ИД
        /// </summary>
        void RemoveById(int Id);

        ///// <summary>
        ///// Метод. Сохранить
        ///// </summary>
        //void SaveChanges();

        /// <summary>
        /// Метод. Получить массив тележек
        /// </summary>
        ICart[] ToArray();

        /// <summary>
        /// Метод. Получить спиок корзин
        /// </summary>
        List<ICart> ToList();

   }
}
