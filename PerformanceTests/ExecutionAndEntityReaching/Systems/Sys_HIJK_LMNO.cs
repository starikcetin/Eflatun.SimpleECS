using PerformanceTests.ExecutionAndEntityReaching.Components;
using PerformanceTests.ExecutionAndEntityReaching.SystemCompositionRequirements;
using SimpleECS.Interfaces;

namespace PerformanceTests.ExecutionAndEntityReaching.Systems
{
    public class Sys_HIJK_LMNO : SysBase
    {
        public Sys_HIJK_LMNO(IEntityFilterer entityFilterer, IComponentRepository componentRepository)
            : base(entityFilterer, componentRepository, new SysReq_HIJK_LMNO()){}

        public override void Execute()
        {
            var entities = EntityFilterer.GetCompatibleEntities(ComponentRequirement);
            foreach (var entity in entities)
            {
                var cH = ComponentRepository.GetComponent<CoH>(entity);
                var cI = ComponentRepository.GetComponent<CoI>(entity);
                var cJ = ComponentRepository.GetComponent<CoJ>(entity);
                var cK = ComponentRepository.GetComponent<CoK>(entity);
                var cL = ComponentRepository.GetComponent<CoL>(entity);
                var cM = ComponentRepository.GetComponent<CoM>(entity);
                var cN = ComponentRepository.GetComponent<CoN>(entity);
                var cO = ComponentRepository.GetComponent<CoO>(entity);

                cH.Val++;
                cI.Val++;
                cJ.Val++;
                cK.Val++;
                cL.Val++;
                cM.Val++;
                cN.Val++;
                cO.Val++;
            }
        }
    }
}