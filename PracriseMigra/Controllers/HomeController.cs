using Microsoft.AspNetCore.Mvc;
using PracriseMigra.Models;
using System.Diagnostics;

namespace PracriseMigra.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

       
    }
}