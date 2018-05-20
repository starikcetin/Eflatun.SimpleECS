using System;
using System.Collections.Generic;
using Eflatun.SimpleECS.Core.Interfaces;

namespace Eflatun.SimpleECS.UnitTests.Instantiation
{
    public class EntityTemplateWithComponentA : IEntityTemplate
    {
        public IEnumerable<Type> ComponentTypes { get; } = new[]
        {
            typeof(ComponentA)
        };
    }
}
