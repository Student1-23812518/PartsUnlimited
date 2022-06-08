using Microsoft.AspNet.Identity.EntityFramework;
//My first change
namespace PartsUnlimited.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}