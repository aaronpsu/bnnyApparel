using Microsoft.AspNetCore.Mvc;

namespace bnnyApparel.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Homepage()
        {
            return View();
        }
        public IActionResult Shop()
        {
            return View();
        }
    }
}
