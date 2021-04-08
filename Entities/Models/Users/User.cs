using Common.UserIdentityCommon;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Models.Users
{
    public class User : IdentityUser<Guid>, IEntity
    {

        [Required(ErrorMessage = "Lastname is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Firstname is required")]
        public string FirstName { get; set; }
        public ICollection<Address> Addresses { get; set; }
    }
}
