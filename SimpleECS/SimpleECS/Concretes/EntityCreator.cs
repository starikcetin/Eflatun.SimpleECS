using System;
using System.Collections.Generic;
using SimpleECS.Interfaces;

namespace SimpleECS.Concretes
{
    public class EntityCreator : IEntityCreator
    {
        private readonly IComponentCreator _componentCreator;

        public EntityCreator(IComponentCreator componentCreator)
        {
            _componentCreator = componentCreator;
        }

        public IEnumerable<IComponent> CreateEntity(IEntityTemplate entityTemplate)
        {
            foreach (var componentType in entityTemplate.ComponentTypes)
            {
                yield return _componentCreator.CreateComponentFromType(componentType);
            }
        }
    }
}
