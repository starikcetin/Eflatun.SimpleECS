using PerformanceTests.ExecutionAndEntityReaching.Components;
using PerformanceTests.ExecutionAndEntityReaching.SystemCompositionRequirements;
using SimpleECS.Interfaces;

namespace PerformanceTests.ExecutionAndEntityReaching.Systems
{
    public class Sys_BC : SysBase
    {
        public Sys_BC(IEntityFilterer entityFilterer, IComponentRepository componentRepository)
            : base(entityFilterer, componentRepository, new SysReq_BC()){}

        public override void Execute()
        {
            var entities = EntityFilterer.GetCompatibleEntities(ComponentRequirement);
            foreach (var entity in entities)
            {
                var cB = ComponentRepository.GetComponent<CoB>(entity);
                var cC = ComponentRepository.GetComponent<CoC>(entity);

                cB.Val++;
                cC.Val++;
            }
        }
    }
}