using Microsoft.AspNetCore.Mvc;
using ThreadHaven.Models;

namespace ThreadHaven.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //GET: Shop/ByCategory/123
        public IActionResult ByCategory(int id)
        {
            if (id == 1)
            {
                ViewData["Category"] = "Sweaters";
            }
            else if (id == 2)
            {
                ViewData["Category"] = "Hoodies";
            }
            else if (id == 3)
            {
                ViewData["Category"] = "pants";
            }
            else if (id == 4)
            {
                ViewData["Category"] = "T-shirts";
            }
            else 
            {
                //we have no id so takes user back to shop index where they can choose a category 
                return RedirectToAction("Index");
            }

            //use product model to make an in-memory list of fake products 
            var products = new List<Product>();
            for(int i=1; i<=5; i++)
            {
                products.Add(new Product { Id = i, Name = "Product"+i, Description="desc" ,Price=00 });
            }
            //now pass the product list to the view for display 
            return View(products);
        }
    }
}
