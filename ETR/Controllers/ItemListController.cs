using Microsoft.AspNetCore.Mvc;

namespace ETR.Controllers
{
    public class ItemListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
