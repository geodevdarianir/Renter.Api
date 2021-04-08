using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.ViewModels.UserIdentityViewModels
{
    public class RegisterModel
    {
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string PhoneNumber { get; set; }

    }
}
