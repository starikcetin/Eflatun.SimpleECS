using System;
using System.Collections.Generic;
using Eflatun.SimpleECS.Core.Interfaces;

namespace Eflatun.SimpleECS.PerformanceTests.Instantiation
{
    internal class EntityTemplate : IEntityTemplate
    {
        private readonly Type[] _componentTypes;
        public IEnumerable<Type> ComponentTypes => _componentTypes;

        public EntityTemplate(int componentCount)
        {
            _componentTypes = new Type[componentCount];
            for (var i = 0; i < componentCount; i++)
            {
                _componentTypes[i] = typeof(Component);
            }
        }
    }
}
