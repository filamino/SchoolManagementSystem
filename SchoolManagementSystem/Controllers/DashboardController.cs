using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SchoolManagementSystem.Controllers
{
    public class DashboardController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public IActionResult Teacher()
        {
            return View();
        }
       

    }
}
