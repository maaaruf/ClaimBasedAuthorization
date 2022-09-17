using Microsoft.AspNetCore.Mvc;

namespace ClaimBasedAuthorizationSample.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
