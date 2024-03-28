namespace SchoolManagementSystem.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public  int MobileNumber { get; set; }
        public DateTime JoinedDate { get; set; }
        public string? Qualification {  get; set; }
        public string? Experience {  get; set; }
        public string? about { get; set; }
        public int GenderId { get; set; }
        public int AddressId { get; set; }
        public int DepartmentId { get; set; }
    }
}
