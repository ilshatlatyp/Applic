using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Applic.Model.Abstract;
using Applic.Model.Concrete;

namespace Applic.Controllers
{
    public class CartController : Controller
    {
        private IProducts productsList;
        public CartController(IProducts products)
        {
            productsList = products;
        }

        public RedirectToRouteResult AddToCart(int productId, string returnUrl)
        {
            Product prod = (Product)productsList.GetProduct(productId);
            if (prod != null)
            {
                GetCart().AddProduct(prod, 1);
            }
            return RedirectToAction("Index", new  { returnUrl });
        }

        private Cart GetCart()
        {
            Cart cart = (Cart)Session["Cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }

    }
}
