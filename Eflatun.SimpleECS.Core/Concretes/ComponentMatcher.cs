using Eflatun.SimpleECS.Core.Interfaces;

namespace Eflatun.SimpleECS.Core.Concretes
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
            for (var i = 0; i < systemComponentRequirement.RequiredComponentTypes.Count; i++)
            {
                if (!_componentRepository.HasComponent(entity, systemComponentRequirement.RequiredComponentTypes[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
