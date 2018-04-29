using System;
using System.Collections.Generic;

namespace SimpleECS
{
    public interface IEntityTemplate
    {
        IEnumerable<Type> ComponentTypes { get;}
    }
}
