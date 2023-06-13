using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb2.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
