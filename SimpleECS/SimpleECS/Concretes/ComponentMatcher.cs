using SimpleECS.Interfaces;

namespace SimpleECS.Concretes
{
    public class ComponentMatcher : IComponentMatcher
    {
        private readonly IComponentRepository _componentRepository;

        public ComponentMatcher(IComponentRepository componentRepository)
        {
            _componentRepository = componentRepository;
        }

        public bool IsMatching(IEntity entity, ISystemComponentRequirement systemComponentRequirement)
        {
            foreach (var requiredComponentType in systemComponentRequirement.RequiredComponentTypes)
            {
                if (!_componentRepository.HasComponent(entity, requiredComponentType))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
