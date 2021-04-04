using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Entities.Models
{
    // https://devdarianigeo.atlassian.net/browse/RG-9
    public class ApplicationUser : IdentityUser
    {
        public User User { get; set; }
    }
}
