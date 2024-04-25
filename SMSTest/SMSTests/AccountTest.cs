using SchoolManagementSystem.Data.Entities;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Services;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SMSTest.SMSTests
{
    [TestClass]
    public class AccountTest
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void Create_Admin_Account()
        {
            var service = CreateSUT();

            var admin = new Register()
            {
                FirstName = "Linda",
                LastName = "Terry",
                Email = "carlos.osoria@gmail.com",
                Password = "123456",
                // Roles = "Admin"
            };

            var result = service.AddUser(admin);

            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void Password_Hash_Is_The_Same()
        {
            var service = CreateSUT();

            var user = new Register()
            {
                FirstName = "Filmon",
                LastName = "Fitwi",
                Email = "filmon@gmail.com",
                Password = "1234",
                // Roles = "User"
            };

            var passwordHash = AccountService.CreatePasswordHash(user.Email, user.Password);

            service.AddUser(user);

            var savedUser = service.GetByEmail(user.Email);

            Assert.IsTrue(savedUser.Password == passwordHash);
        }

        private AccountService CreateSUT()
        {
            return new AccountService(new SchoolManagementSystem.Data.SmsdbContext());
        }

    }
}