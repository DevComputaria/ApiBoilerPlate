using System;
using System.Collections.Generic;
using System.Text;

namespace API.Boilerplate.Domain.Entities.Base
{
    public class EntityBase
    {
        public EntityBase()
        {
            Id = Guid.NewGuid();
        }
        public virtual Guid Id { get; set; }
    }
}
