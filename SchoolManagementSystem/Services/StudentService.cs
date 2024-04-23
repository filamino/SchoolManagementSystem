using SchoolManagementSystem.Data;

namespace SchoolManagementSystem.Services
{
    public class StudentService
    {
        SmsdbContext _dbContext;
        public StudentService(SmsdbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int StudentCount()
        {
            var  result= _dbContext.Students.Count();
           
            return result;
        }
    }
}
