using Microsoft.AspNetCore.Mvc;

namespace TraversalRezervasyon.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
