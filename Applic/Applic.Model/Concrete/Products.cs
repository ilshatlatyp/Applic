using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Applic.Model.Abstract;
using System.Data.Entity;

namespace Applic.Model.Concrete
{
    public class Products:IProducts
    {
        /// <summary>
        /// Поле. Набор 
        /// </summary>
        private DbSet<Product> _productDbSet;

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
        public DbSet<Product> ProductDbSet
        {
            get
            {
                return _productDbSet;
            }
            set
            {
                _productDbSet = value;
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public Products(DbSet<Product> productDbSet)//, SaveChangesDelegate saveChangesDelegat
        {
            _productDbSet = productDbSet;
           // _saveChangesDelegate = saveChangesDelegat;
        }

        /// <summary>
        /// Метод. Создать  
        /// </summary>
        public IProduct Create()
        {
            IProduct product;
            product = (IProduct)new Product();
            return product;
        }

        /// <summary>
        /// Метод. Добавить  в список
        /// </summary>
        public void Add(IProduct product)
        {
            _productDbSet.Add((Product)product);
         //   SaveChanges();
        }

        /// <summary>
        /// Метод. Удалить  из списка
        /// </summary>
        public void Remove(IProduct product)
        {
            _productDbSet.Remove((Product)product);
        //    SaveChanges();
        }

        /// <summary>
        /// Метод. Получить  по ИД
        /// </summary>
        public IProduct GetProduct(int Id)
        {
            return ((IProduct)_productDbSet.Where(c => c.ProductId == Id));
        }

        /// <summary>
        /// Метод. Удалить по ИД
        /// </summary>
        public void RemoveById(int Id)
        {
            IProduct product;
            product = GetProduct(Id);
            _productDbSet.Remove((Product)product);
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
        public IProduct[] ToArray()
        {
            return (_productDbSet.ToArray<IProduct>());
        }

        /// <summary>
        /// Метод. Получить спиок 
        /// </summary>
        public List<IProduct> ToList()
        {
            return (_productDbSet.ToList<IProduct>());
        }
    }
}
