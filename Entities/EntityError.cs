using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class EntityError<TEntity> : Exception
    {
        public string Error { get; set; }
        public EntityError(TEntity entity, string message)
        : base(String.Format("Invalid  Entity: {0}", typeof(TEntity)))
        {
            Error = message;
        }
    }
}
