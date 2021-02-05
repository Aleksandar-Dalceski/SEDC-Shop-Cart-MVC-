using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DomasnaShoppingCart.Models.ShoppAdmin;
using Microsoft.AspNetCore.Mvc;

namespace DomasnaShoppingCart.Controllers
{
    public class ShoppAdminController : Controller
    {
        public IActionResult Index()
        {
            return View(DataModelShopp.Shoppings);
        }
        public IActionResult Create()
        {
            return View();
;        }
        public IActionResult CreateNewBoot(Shopping shopping)
        {
           DataModelShopp.Shoppings.Add(shopping);
           return RedirectToAction("Index");
            
        }
        public IActionResult Edit(int id)
        {
            var editBoot = DataModelShopp.Shoppings.FirstOrDefault(x => x.Id == id);
            return View(editBoot);
        }
        public IActionResult Update(Shopping shopping)
        {
            var updateBoot = DataModelShopp.Shoppings.FirstOrDefault(x => x.Id == shopping.Id);
            updateBoot.Id = shopping.Id;
            updateBoot.Name = shopping.Name;
            updateBoot.Price = shopping.Price;
            updateBoot.Category = shopping.Category;
            updateBoot.Quantity = shopping.Quantity;
            updateBoot.Expiry = shopping.Expiry;
            updateBoot.Brand = shopping.Brand;
            updateBoot.LogoUrl = shopping.LogoUrl;
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            DataModelShopp.Shoppings.RemoveAll(x => x.Id == id);
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            var detailsBoot = DataModelShopp.Shoppings.FirstOrDefault(x => x.Id == id);
            return View(detailsBoot);
        }
        public IActionResult Back()
        {
            return RedirectToAction("Index");
        }


    }
}