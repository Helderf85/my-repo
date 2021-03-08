using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Core
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }
    }
}
