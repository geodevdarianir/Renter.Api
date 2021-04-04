using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Address
    {
        public Guid ID { get; set; }
        public string Street { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
    }
}
