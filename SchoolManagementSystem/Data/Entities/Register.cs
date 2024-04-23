using System.Collections.Generic;

namespace SchoolManagementSystem.Data.Entities;

public partial class Register
{
    public int UserId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

 
    public virtual ICollection<Login> Logins { get; set; } = new List<Login>();

    public virtual ICollection<Profile> Profiles { get; set; } = new List<Profile>();
}
