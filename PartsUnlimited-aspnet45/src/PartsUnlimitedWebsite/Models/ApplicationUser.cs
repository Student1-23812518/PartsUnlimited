using Microsoft.AspNet.Identity.EntityFramework;
//My first change
//My second change
namespace PartsUnlimited.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}