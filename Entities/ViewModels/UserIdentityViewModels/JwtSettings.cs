using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.UserIdentityViewModels
{
    public class JwtSettings
    {
        public string Issuer { get; set; }

        public string Secret { get; set; }

        public int ExpirationInDays { get; set; }
    }
}
