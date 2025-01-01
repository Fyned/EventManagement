// EventManagement.Infrastructure/Entities/ApplicationUser.cs
using Microsoft.AspNetCore.Identity;
using System;

namespace EventManagement.Infrastructure.Entities
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        // Additional properties can be added here
    }
}
