using Microsoft.AspNetCore.Identity;

namespace UserRegistration.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
