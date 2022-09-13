using Microsoft.AspNetCore.Mvc;

namespace ClaimBasedAuthorizationSample.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
