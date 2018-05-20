using System;
using System.Collections.Generic;
using Eflatun.SimpleECS.Core.Interfaces;

namespace Eflatun.SimpleECS.UnitTests.TemplateDefinition
{
    public class EntityTemplateWithComponentA : IEntityTemplate
    {
        public IEnumerable<Type> ComponentTypes { get; } = new[]
        {
            typeof(ComponentA)
        };
    }
}
