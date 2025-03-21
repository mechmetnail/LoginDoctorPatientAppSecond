using Microsoft.AspNetCore.Identity;

namespace LoginDoctorPatientApp02.Models
{
    public class Users : IdentityUser
    {
        public string FullName { get; set; }
    }
}
