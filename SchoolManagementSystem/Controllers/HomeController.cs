using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Data;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Printing;
using Microsoft.AspNetCore.Authorization;

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

        [Authorize]
        public IActionResult Index()
        {
            int studentCount = _dbContext.Students.Count();
            ViewBag.StudentCount = studentCount;
            int teachers = _dbContext.Teachers.Count();
            ViewBag.teachersCount= teachers;
            int departments = _dbContext.Departments.Count();
            ViewBag.DepartmentCount = departments;
            return View();
        }

        
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public int StudentCount()
        {
            var result = _dbContext.Students.Count();
            ViewBag.StudentCount = result;
            
            return result;
        }
    }
}
