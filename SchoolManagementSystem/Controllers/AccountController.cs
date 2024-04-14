//using Microsoft.AspNetCore.Authentication;
//using Microsoft.AspNetCore.Authentication.Cookies;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.VisualBasic;
//using System.Security.Claims;

//namespace SchoolManagementSystem.Controllers
//{
//    public class AccountController : Controller
//    {
//        public IActionResult Index()
//        {
//            return View();
//        }

//        public IActionResult Login()
//        {
//            return View();
//        }

//        [HttpPost]
//        public async Task<IActionResult> Login(string email, string password)
//        {
//            if (email == "Filmon@gmail.com" && password == "1234")
//            {

//                var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
//                identity.AddClaim(new Claim(ClaimTypes.Name, "Filmon"));

//                var userPrincipal = new ClaimsPrincipal(identity);

//                await HttpContext.SignInAsync(userPrincipal);
//                return Redirect("Home/Index");
//            }
//            else {
//                ViewBag.ErrorMessage = "Invalid Credential";
//                return View();
//            }
//        }

//        public async Task< IActionResult> Logout()
//        {
//            await HttpContext.SignOutAsync();
//            return LocalRedirect("/Home/Index");
//                    }
//    }
//}
