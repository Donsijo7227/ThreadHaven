using Microsoft.AspNetCore.Mvc;

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
            return View();
        }
    }
}
