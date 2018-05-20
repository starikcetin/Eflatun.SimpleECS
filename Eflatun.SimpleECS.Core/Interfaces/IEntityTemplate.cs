using System;
using System.Collections.Generic;

namespace Eflatun.SimpleECS.Core.Interfaces
{
    public interface IEntityTemplate
    {
        IEnumerable<Type> ComponentTypes { get;}
    }
}
