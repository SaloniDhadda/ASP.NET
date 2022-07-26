using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Models
{
    public class employee : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
