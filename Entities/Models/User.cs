using Common.UserIdentityCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Models
{
    public class User
    {

        [Key]
        public Guid ID { get; set; }
        [Required(ErrorMessage = "User Name is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "User Name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "User Name is required")]
        public DateTime BirthDay { get; set; }
        public ICollection<Address> Adresses { get; set; }
        private string userRole = string.Empty;
        [Required(ErrorMessage = "User Name is required")]
        public string UserArt
        {
            get { return userRole; }
            set
            {
                if (value != UserRoles.Admin || value != UserRoles.Client || value != UserRoles.Admin)
                {
                    throw new Exception();
                }
                userRole = value;
            }
        }
        public string Email { get; set; }
        public string Sex { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
    }
}
