using System;
using System.Collections.Generic;
using SimpleECS.Interfaces;

namespace UnitTests.ComponentRegisterAndUnregister
{
    public class EmptyEntityTemplate : IEntityTemplate
    {
        public IEnumerable<Type> ComponentTypes { get; } = new Type[0];
    }
}
