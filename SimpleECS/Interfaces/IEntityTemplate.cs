using System;
using System.Collections.Generic;

namespace SimpleECS.Interfaces
{
    public interface IEntityTemplate
    {
        IEnumerable<Type> ComponentTypes { get;}
    }
}
