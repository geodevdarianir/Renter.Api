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

        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }
        public ICollection<Address> Addresses { get; set; }
        //[Required(ErrorMessage = "BirthDay is required")]
        //public DateTime BirthDay { get; set; }
        //[Required(ErrorMessage = "Adresse is required")]
        //public ICollection<Address> Adresses { get; set; }
        //private string userRole = string.Empty;
        //[Required(ErrorMessage = "User Art is required")]
        //public string UserArt
        //{
        //    get { return userRole; }
        //    set
        //    {
        //        if (value != UserRoles.Admin || value != UserRoles.Client || value != UserRoles.Admin)
        //        {
        //            throw new Exception();
        //        }
        //        userRole = value;
        //    }
        //}
        //[Required(ErrorMessage = "Email is required")]
        //[DataType(DataType.EmailAddress)]
        //[EmailAddress]
        //public string Email { get; set; }
        //[Required(ErrorMessage = "Sex is required")]
        //public string Sex { get; set; }
        //[Required(ErrorMessage = "Password is required")]
        //[StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        //[DataType(DataType.Password)]
        //public string Password { get; set; }
        //[Required(ErrorMessage = "PhoneNumber is required")]
        //public string PhoneNumber { get; set; }
    }
}
