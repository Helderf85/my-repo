using Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Custumer
{
    public class Custumer: Entity 
    {
        public Custumer()
        {

        }

        public Custumer ( string name, Guid id)
        {
            Name = name;
            Id = id;
        }

        public string Name { get; private set; }
    }
}
