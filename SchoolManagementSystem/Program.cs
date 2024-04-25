using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using SchoolManagementSystem.Data.Entities;
using SchoolManagementSystem.Services;

namespace SchoolManagementSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddScoped<SmsdbContext>();
            builder.Services.AddScoped<AccountService>();
            builder.Services.AddScoped<StudentService>();
            builder.Services.AddScoped<SearchService>();
            builder.Services.AddControllersWithViews();
            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>

            {
                options.LoginPath = "/Account/Login";
                options.LogoutPath = "/Account/Logout";
            }
            );
            builder.Services.AddDbContext<SmsdbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection"))
            .LogTo(Console.WriteLine).
            EnableSensitiveDataLogging().
            UseLazyLoadingProxies());


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Account}/{action=Login}/{id?}");

            app.Run();
        }
    }
}
