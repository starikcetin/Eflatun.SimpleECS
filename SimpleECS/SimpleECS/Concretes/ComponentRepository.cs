using System.Collections.Generic;
using SimpleECS.Interfaces;

namespace SimpleECS.Concretes
{
    public class ComponentRepository : IComponentRepository
    {
        private readonly Dictionary<IEntity, ISet<IComponent>> _entityComponents =
            new Dictionary<IEntity, ISet<IComponent>>();

        public void Register(IEntity entity, IComponent component)
        {
            EnsureKeyPresent(entity);
            _entityComponents[entity].Add(component);
        }

        private void EnsureKeyPresent(IEntity entity)
        {
            if (!_entityComponents.ContainsKey(entity))
            {
                _entityComponents[entity] = new HashSet<IComponent>();
            }
        }
    }
}
