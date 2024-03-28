namespace SchoolManagementSystem.Models
{
    public class Student
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required int AdmissionId { get; set;}
        public DateTime DateOfBirth { get; set;}
        public int PhoneNumber { get; set;}
        public string? about { get; set;}
        public int GenderId { get; set; }
        public int AddressId {  get; set; }
        public int DepartmentId {  get; set; }
    }
}
