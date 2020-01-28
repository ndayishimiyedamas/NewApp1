using Microsoft.AspNetCore.Mvc;

namespace NewApp.Controllers
{
    public class AboutController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}