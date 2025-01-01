using Microsoft.AspNetCore.Identity;
using System;

namespace EventManagement.Core.Entities
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        // Ekstra özellikler ekleyebilirsiniz
        // Örneğin:
        // public string FirstName { get; set; }
        // public string LastName { get; set; }
    }
}
