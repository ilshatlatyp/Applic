using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Applic.Model.Concrete;

namespace Applic.Model.Abstract
{
    public interface IProducts
    {
        /// <summary>
        /// Свойство. Задает и возвращает набор товаров
        /// </summary>
        DbSet<Product> ProductDbSet { get; set; }

        /// <summary>
        /// Метод. Создает товар
        /// </summary>
        IProduct Create();

        /// <summary>
        /// Метод. Получить продукт по идентификатору
        /// </summary>
        IProduct GetProduct(int Id);

        /// <summary>
        /// Метод. Добавить продукт в список
        /// </summary>
        void Add(IProduct product);

        /// <summary>
        /// Метод. Удалить проукт из списка
        /// </summary>
        void Remove(IProduct product);

        /// <summary>
        /// Метод. Удалить продукт по идентификатору
        /// </summary>
        void RemoveById(int Id);

        ///// <summary>
        ///// Метод. Сохранить изменения
        ///// </summary>
        //void SaveChanges();

        /// <summary>
        /// Метод. Получить  массив
        /// </summary>
        IProduct[] ToArray();

        /// <summary>
        /// Метод. Привести к списку
        /// </summary>
        List<IProduct> ToList();
    }
}
