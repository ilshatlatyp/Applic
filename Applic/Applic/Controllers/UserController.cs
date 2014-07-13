using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Applic.Model.Abstract;
using Applic.Model.Concrete;

namespace Applic.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/
        private static EFContext EF = new EFContext();
        IQueryable<Product> product = EF.EProduct;
        //IQueryable<User> ee1 = EF.EUser;
        //IQueryable<Cart> ee2 = EF.ECart;
        IQueryable<Category> category = EF.ECategory;
      

        public ActionResult Index()
        {
            ViewBag.Category = category;
            return View(product);
        }

    }
}
