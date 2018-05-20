using System;
using System.Collections.Generic;
using Eflatun.SimpleECS.Core.Interfaces;

namespace Eflatun.SimpleECS.UnitTests.ComponentRegisterAndUnregister
{
    public class EmptyEntityTemplate : IEntityTemplate
    {
        public IEnumerable<Type> ComponentTypes { get; } = new Type[0];
    }
}
