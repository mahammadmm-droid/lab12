using lab12.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace lab12.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

      
    }
}
