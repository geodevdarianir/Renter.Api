using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public interface IEntity
    {
        public Guid Id { get; set; }
    }
}
