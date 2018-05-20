using System;
using System.Collections.Generic;
using SimpleECS.Interfaces;

namespace UnitTests.Instantiation
{
    public class EntityTemplateWithComponentA : IEntityTemplate
    {
        public IEnumerable<Type> ComponentTypes { get; } = new[]
        {
            typeof(ComponentA)
        };
    }
}
