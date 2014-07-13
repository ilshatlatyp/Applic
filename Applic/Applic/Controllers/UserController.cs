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
        private IProducts productsList;

        public UserController(IProducts products)
        {
            productsList = products;
        }

        public ActionResult Index()
        {
            ViewBag.Category = category;
            return View(product);
        }

        public RedirectToRouteResult AddToCart(int productId, string returnUrl)
        {
            Product prod = (Product)productsList.GetProduct(productId);
            if (prod != null)
            {
                GetCart().AddProduct(prod, 1);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        private Cart GetCart()
        {
            Cart cart = (Cart)Session["User"];
            if (cart == null)
            {
                cart = new Cart();
                Session["User"] = cart;
            }
            return cart;
        }
    }
}
