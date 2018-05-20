using System;
using System.Collections.Generic;
using Eflatun.SimpleECS.Core.Interfaces;

namespace Eflatun.SimpleECS.UnitTests.ComponentRegisterAndUnregister
{
    public class EntityTemplateWithComponent : IEntityTemplate
    {
        public IEnumerable<Type> ComponentTypes { get; } = new []
        {
            typeof(Component)
        };
    }
}
