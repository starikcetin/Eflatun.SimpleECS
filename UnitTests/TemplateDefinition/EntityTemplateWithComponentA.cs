using System;
using System.Collections.Generic;
using SimpleECS.Interfaces;

namespace UnitTests.TemplateDefinition
{
    public class EntityTemplateWithComponentA : IEntityTemplate
    {
        public IEnumerable<Type> ComponentTypes { get; } = new[]
        {
            typeof(ComponentA)
        };
    }
}
