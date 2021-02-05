using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomasnaShoppingCart.Models.ShoppAdmin
{
    public static class DataModelShopp
    {
        public static List<Shopping> Shoppings = new List<Shopping>()
        {
            new Shopping(){Id = 1,Name ="Adidas Boot",Price = 85,Quantity = 10,Expiry = DateTime.Now.AddDays(10),Category="Boots",Brand="Adidas Predator",LogoUrl="https://cdn.pixabay.com/photo/2020/07/22/09/28/adidas-5428548_960_720.jpg"},
              new Shopping(){Id = 2,Name ="Nike Boot",Price = 240,Quantity = 10,Expiry = DateTime.Now.AddDays(10),Category="Boots",Brand="Nike Mercurial",LogoUrl="https://cdn.pixabay.com/photo/2012/02/29/15/44/football-19115_1280.jpg"}
        };
        public static List<Shopping> Cart = new List<Shopping>();
       
    }
}
