using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.VisualBasic;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Data.Entities;
using SchoolManagementSystem.Services;
using System.Security.Claims;

namespace SchoolManagementSystem.Controllers
{
    public class AccountController : Controller
    {
        private readonly AccountService _accountService;
        private readonly SmsdbContext _smsdbContext;

        public AccountController(SmsdbContext smsdbContext, AccountService accountService)
        {
            _accountService= accountService;
            _smsdbContext = smsdbContext;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(string email, string password)
        {

            var user = _smsdbContext.Registers.FirstOrDefault(u => u.Email == email);

            if(user == null)
            {
                ViewBag.ErrorMessage = "Invalid Credential";
                return View();
            }

            var passwordHash = AccountService.CreatePasswordHash(email,password);

            if (user.Password == passwordHash)
            {

                var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, user.Email));
                identity.AddClaim(new Claim(ClaimTypes.Name, $"{ user.FirstName}"));
                identity.AddClaim(new Claim(ClaimTypes.Email, user.Email));
                identity.AddClaim(new Claim("IsAdmin", "True"));

                var userPrincipal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync(userPrincipal);
                return Redirect("/Home/Index");
            }
            else
            {
                ModelState.AddModelError("", "Invalid Credential");
                ViewBag.ErrorMessage = "Invalid Credential";
                return View();
            }
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return LocalRedirect("/Account/Login");
        }

        [HttpPost]
        public   IActionResult Register(Register register)
        {
            if (ModelState.IsValid)
            {
               var result= _accountService.AddUser(register); 
                if(register!= null)
                {
                    // error message
                    return View();
                }
                Redirect ("/Account/Login");
            }
            
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Forget()
        {
            return View();
        }

    }
}
