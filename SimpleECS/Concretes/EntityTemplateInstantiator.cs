using SimpleECS.Interfaces;

namespace SimpleECS.Concretes
{
    public class EntityTemplateInstantiator : IEntityTemplateInstantiator
    {
        private readonly IComponentCreator _componentCreator;
        private readonly IComponentRepository _componentRepository;
        private readonly IEntityCreator _entityCreator;

        public EntityTemplateInstantiator(IEntityCreator entityCreator, IComponentCreator componentCreator,
            IComponentRepository componentRepository)
        {
            _componentCreator = componentCreator;
            _componentRepository = componentRepository;
            _entityCreator = entityCreator;
        }

        public Entity Instantiate(IEntityTemplate entityTemplate)
        {
            var entity = _entityCreator.CreateEntity();

            foreach (var componentType in entityTemplate.ComponentTypes)
            {
                var component = _componentCreator.CreateComponentFromType(componentType);
                _componentRepository.Register(entity, component);
            }

            return entity;
        }
    }
}
