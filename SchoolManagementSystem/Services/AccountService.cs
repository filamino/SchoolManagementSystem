using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Data.Entities;
using System.Text;

namespace SchoolManagementSystem.Services
{
    public class AccountService
    {

        private readonly SmsdbContext _dbContext;
            
            public AccountService(SmsdbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int AddUser(Register register)
        {
            register.Password = CreatePasswordHash(register.Email, register.Password);
            _dbContext.Registers.Add(register);
            return _dbContext.SaveChanges();
        }

        public static string CreatePasswordHash(string email, string password)
        {
           using(SHA256  sha256 = SHA256.Create())
            {
                var targetString = $"{email}|{password}|school12";
                
                var targetByte=Encoding.UTF8.GetBytes(targetString);
                var hashBytes = sha256.ComputeHash(targetByte);
                var hasString = Convert.ToBase64String(hashBytes);
                return hasString;
            } 
        }
    }
}
