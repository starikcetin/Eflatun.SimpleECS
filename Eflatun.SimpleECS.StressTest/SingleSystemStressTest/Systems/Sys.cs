using Eflatun.SimpleECS.Core.Interfaces;
using Eflatun.SimpleECS.StressTest.SingleSystemStressTest.Components;
using Eflatun.SimpleECS.StressTest.SingleSystemStressTest.SystemCompositionRequirements;

namespace Eflatun.SimpleECS.StressTest.SingleSystemStressTest.Systems
{
    public class Sys : ISystem
    {
        private readonly IEntityFilterer _entityFilterer;
        private readonly IComponentRepository _componentRepository;
        private readonly ISystemComponentRequirement _componentRequirement = new SysReq();

        public Sys(IEntityFilterer entityFilterer, IComponentRepository componentRepository)
        {
            _entityFilterer = entityFilterer;
            _componentRepository = componentRepository;
        }

        public void Execute()
        {
            var entities = _entityFilterer.GetCompatibleEntities(_componentRequirement);
            foreach (var entity in entities)
            {
                var cA = _componentRepository.GetComponent<CoA>(entity);
                var cB = _componentRepository.GetComponent<CoB>(entity);
                var cC = _componentRepository.GetComponent<CoC>(entity);
                var cD = _componentRepository.GetComponent<CoD>(entity);
                var cE = _componentRepository.GetComponent<CoE>(entity);
                var cF = _componentRepository.GetComponent<CoF>(entity);
                var cG = _componentRepository.GetComponent<CoG>(entity);

                var cH = _componentRepository.GetComponent<CoH>(entity);
                var cI = _componentRepository.GetComponent<CoI>(entity);
                var cJ = _componentRepository.GetComponent<CoJ>(entity);
                var cK = _componentRepository.GetComponent<CoK>(entity);
                var cL = _componentRepository.GetComponent<CoL>(entity);
                var cM = _componentRepository.GetComponent<CoM>(entity);
                var cN = _componentRepository.GetComponent<CoN>(entity);
                var cO = _componentRepository.GetComponent<CoO>(entity);

                cA.Val++;
                cB.Val++;
                cC.Val++;
                cD.Val++;
                cE.Val++;
                cF.Val++;
                cG.Val++;

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
