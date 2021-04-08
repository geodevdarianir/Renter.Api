using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.ViewModels.UserIdentityViewModels
{
    public class RegisterModel
    {
        //[Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

        //[Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }

        //[EmailAddress]
        //[Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        //[Required(ErrorMessage = "Password is required")]
        //[DataType(DataType.Password)]
        public string Password { get; set; }

        //[DataType(DataType.Password)]
        //[Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        //public string ConfirmPassword { get; set; }
    }
}
