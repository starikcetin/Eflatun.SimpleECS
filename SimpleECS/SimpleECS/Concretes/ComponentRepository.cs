using System.Collections.Generic;
using System.Linq;
using SimpleECS.Interfaces;

namespace SimpleECS.Concretes
{
    public class ComponentRepository : IComponentRepository
    {
        private readonly Dictionary<IEntity, HashSet<IComponent>> _entityComponents =
            new Dictionary<IEntity, HashSet<IComponent>>();

        public void Register(IEntity entity, IComponent component)
        {
            EnsureKeyPresent(entity);
            _entityComponents[entity].Add(component);
        }

        public void Unregister(IEntity entity, IComponent component)
        {
            EnsureKeyPresent(entity);
            _entityComponents[entity].Remove(component);
        }

        public IReadOnlyCollection<IComponent> GetComponents(IEntity entity)
        {
            EnsureKeyPresent(entity);
            return _entityComponents[entity];
        }

        public T GetComponent<T>(IEntity entity) where T : IComponent
        {
            EnsureKeyPresent(entity);
            return _entityComponents[entity].OfType<T>().Single();
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
