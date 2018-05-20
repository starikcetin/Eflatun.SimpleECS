using System.Collections.Generic;
using SimpleECS.Interfaces;

namespace SimpleECS.Concretes
{
    public class EntityFilterer : IEntityFilterer
    {
        private readonly IComponentRepository _componentRepository;
        private readonly IComponentMatcher _componentMatcher;

        public EntityFilterer(IComponentRepository componentRepository, IComponentMatcher componentMatcher)
        {
            _componentRepository = componentRepository;
            _componentMatcher = componentMatcher;
        }

        public IEnumerable<IEntity> GetCompatibleEntities(ISystemComponentRequirement systemComponentRequirement)
        {
            foreach (var entity in _componentRepository.AllEntities)
            {
                if (_componentMatcher.IsMatching(entity, systemComponentRequirement))
                {
                    yield return entity;
                }
            }
        }
    }
}
