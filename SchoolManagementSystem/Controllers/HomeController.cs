using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Models;
using System.Diagnostics;

namespace SchoolManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SmsdbContext _dbContext;

        public HomeController(ILogger<HomeController> logger, SmsdbContext smsdbContext)
        {
            _logger = logger;
            _dbContext = smsdbContext;
        }

        public IActionResult Index()
        {
            var students = _dbContext.Students.ToList();
            ViewBag.StudentList = students;
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
