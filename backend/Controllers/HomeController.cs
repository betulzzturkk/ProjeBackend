using Microsoft.AspNetCore.Mvc;
using backend.Models;
using System.Diagnostics;

namespace backend.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Ana Sayfa
        public IActionResult Index()
        {
            return View();
        }

        // Eğitimler sayfası
        public IActionResult Egitimler()
        {
            return View();
        }

        // Giriş sayfası (GET)
        public IActionResult girisekran()
        {
            return View();
        }

        // Giriş işlemi (POST)
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            // Basit giriş kontrolü (örnek)
            if (username == "admin" && password == "password")
            {
                return RedirectToAction("AnaSayfa"); // Başarılı giriş sonrası yönlendirme
            }
            else
            {
                // Hatalı giriş, hata mesajı gösterme
                ViewBag.ErrorMessage = "Geçersiz kullanıcı adı veya şifre.";
                return View("girisekran"); // Hatalı giriş, aynı sayfaya geri dönme
            }
        }

        // Ana Sayfa (Başarılı giriş sonrası)
        public IActionResult AnaSayfa()
        {
            return View();
        }

        // Gizlilik sayfası
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
