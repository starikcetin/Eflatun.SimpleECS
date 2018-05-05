using System;
using System.Collections.Generic;
using System.Linq;
using SimpleECS.Interfaces;

namespace SimpleECS.Concretes
{
    public class ComponentRepository : IComponentRepository
    {
        private readonly Dictionary<IEntity, HashSet<IComponent>> _entityComponents =
            new Dictionary<IEntity, HashSet<IComponent>>();

        public IReadOnlyCollection<IEntity> AllEntities => _entityComponents.Keys;

        public void Register(IEntity entity)
        {
            EnsureKeyPresent(entity);
        }

        public void Register(IEntity entity, IComponent component)
        {
            EnsureKeyPresent(entity);
            _entityComponents[entity].Add(component);
        }

        public void Unregister(IEntity entity, IComponent component)
        {
            //EnsureKeyPresent(entity);
            _entityComponents[entity].Remove(component);
        }

        public IReadOnlyCollection<IComponent> GetComponents(IEntity entity)
        {
            //EnsureKeyPresent(entity);
            return _entityComponents[entity];
        }

        public T GetComponent<T>(IEntity entity) where T : IComponent
        {
            //EnsureKeyPresent(entity);

            foreach (var c in _entityComponents[entity])
            {
                if (c.GetType() == typeof(T))
                {
                    return (T) c;
                }
            }

            throw new Exception("Entity doesn't contain the specified component type.");
        }

        public bool HasComponent(IEntity entity, Type componentType)
        {
            //EnsureKeyPresent(entity);
            
            foreach (var c in _entityComponents[entity])
            {
                if (c.GetType() == componentType) return true;
            }

            return false;
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
