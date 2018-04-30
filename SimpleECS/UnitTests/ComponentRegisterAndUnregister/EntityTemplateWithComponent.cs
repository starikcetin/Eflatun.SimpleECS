using System;
using System.Collections.Generic;
using SimpleECS.Interfaces;

namespace UnitTests.ComponentRegisterAndUnregister
{
    public class EntityTemplateWithComponent : IEntityTemplate
    {
        public IEnumerable<Type> ComponentTypes { get; } = new []
        {
            typeof(Component)
        };
    }
}
