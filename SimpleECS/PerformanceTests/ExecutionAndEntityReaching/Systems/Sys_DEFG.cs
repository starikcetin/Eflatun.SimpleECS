using PerformanceTests.ExecutionAndEntityReaching.Components;
using PerformanceTests.ExecutionAndEntityReaching.SystemCompositionRequirements;
using SimpleECS.Interfaces;

namespace PerformanceTests.ExecutionAndEntityReaching.Systems
{
    public class Sys_DEFG : SysBase
    {
        public Sys_DEFG(IEntityFilterer entityFilterer, IComponentRepository componentRepository)
            : base(entityFilterer, componentRepository, new SysReq_DEFG()){}

        public override void Execute()
        {
            var entities = EntityFilterer.GetCompatibleEntities(ComponentRequirement);
            foreach (var entity in entities)
            {
                var cD = ComponentRepository.GetComponent<CoD>(entity);
                var cE = ComponentRepository.GetComponent<CoE>(entity);
                var cF = ComponentRepository.GetComponent<CoF>(entity);
                var cG = ComponentRepository.GetComponent<CoG>(entity);

                cD.Val++;
                cE.Val++;
                cF.Val++;
                cG.Val++;
            }
        }
    }
}