using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DomasnaShoppingCart.Models.ShoppAdmin;

namespace DomasnaShoppingCart.Controllers
{
    public class ShopCartController : Controller
    {
        public IActionResult Index()
        {
            return View(DataModelShopp.Shoppings);
        }

        public IActionResult AddToCart(int id)
        {
            
            var cart = DataModelShopp.Shoppings.FirstOrDefault(x => x.Id == id);
           
            if(cart != null)
            {
                DataModelShopp.Cart.Add(cart);
                cart.Quantity--;
            }
            
            ViewBag.Count = DataModelShopp.Cart.Count();
            return View("Index",DataModelShopp.Shoppings);
        }
        public IActionResult MyCart()
        {
            return View(DataModelShopp.Cart);
        }
        public IActionResult Delete(int id)
        {
            var product = DataModelShopp.Cart.FirstOrDefault(x => x.Id == id);
            DataModelShopp.Cart.Remove(product);
            return RedirectToAction("MyCart");
        }
    }
}