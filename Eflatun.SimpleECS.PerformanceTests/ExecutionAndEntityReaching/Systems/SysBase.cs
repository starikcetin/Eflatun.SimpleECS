using Eflatun.SimpleECS.Core.Interfaces;

namespace Eflatun.SimpleECS.PerformanceTests.ExecutionAndEntityReaching.Systems
{
    public abstract class SysBase : ISystem
    {
        protected readonly IEntityFilterer EntityFilterer;
        protected readonly IComponentRepository ComponentRepository;
        protected readonly ISystemComponentRequirement ComponentRequirement;

        protected SysBase(IEntityFilterer entityFilterer, IComponentRepository componentRepository, ISystemComponentRequirement componentRequirement)
        {
            ComponentRequirement = componentRequirement;
            ComponentRepository = componentRepository;
            EntityFilterer = entityFilterer;
        }

        public abstract void Execute();
    }
}
