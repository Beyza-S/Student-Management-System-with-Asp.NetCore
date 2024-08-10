using Microsoft.AspNetCore.Mvc;
using projebeyza.Models;
using System.Diagnostics;

namespace projebeyza.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.WelcomeMessage = "Ana Ekrana Hoşgeldiniz<br>Beyza Soy Dönem Projesi";
            return View();
        }

        public IActionResult Index1()
        {
            var student = new Student { Id = 1, Name = "Beyza Soy", Age = 20 };
            ViewBag.Message = "Oğrenci Detay Sayfasına Hosgeldiniz!";
            return View(student);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Uygulamada öğrencileri ekleyip,silip,güncelleyebilmektesiniz.";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
