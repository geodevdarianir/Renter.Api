using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using Common.UserIdentityCommon;
using System.Linq;

namespace Entities.Models.Users
{
    public class Role : IdentityRole<Guid>
    {
        public override string Name
        {
            get => base.Name; set
            {
                var props = typeof(UserRoles).GetFields();
                if (props.Any(p => p.Name == value))
                {
                    base.Name = value;
                }
                else
                {
                    throw new Exception("Role is only Admin, Client or Contractor!");
                }
            }
        }
    }
}
