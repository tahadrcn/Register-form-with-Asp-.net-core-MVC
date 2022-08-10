using Microsoft.AspNetCore.Mvc;

namespace courseapp.Controllers
{
    public class homecontroller:Controller
    {
        // localhost:5000/home/Index
        public IActionResult Index()
        {
            return View();   
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
