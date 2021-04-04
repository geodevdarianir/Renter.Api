using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Entities.Models
{
    public class ApplicationUser : IdentityUser
    {
        public User User { get; set; }
    }
}
