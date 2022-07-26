using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Models
{
    public class department : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
