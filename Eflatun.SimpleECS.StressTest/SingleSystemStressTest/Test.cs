using System;
using System.Diagnostics;
using Eflatun.SimpleECS.Core.Concretes;
using Eflatun.SimpleECS.Core.Interfaces;
using Eflatun.SimpleECS.StressTest.SingleSystemStressTest.EntityTemplates;
using Eflatun.SimpleECS.StressTest.SingleSystemStressTest.Systems;

namespace Eflatun.SimpleECS.StressTest.SingleSystemStressTest
{
    internal class Test
    {
        private readonly IComponentRepository _componentRepository;
        private readonly IUniqueIdProvider _uniqueIdProvider;
        private readonly IEntityCreator _entityCreator;
        private readonly IComponentCreator _componentCreator;
        private readonly IEntityTemplateInstantiator _entityTemplateInstantiator;
        private readonly IComponentMatcher _componentMatcher;
        private readonly IEntityFilterer _entityFilterer;
        private readonly ISystemRepository _systemRepository;
        private readonly ISystemsExecuter _systemsExecuter;

        public Test()
        {
            _componentRepository = new ComponentRepository();
            _uniqueIdProvider = new UniqueIdProvider();
            _entityCreator = new EntityCreator(_uniqueIdProvider);
            _componentCreator = new ComponentCreator();
            _entityTemplateInstantiator =
                new EntityTemplateInstantiator(_entityCreator, _componentCreator, _componentRepository);
            _componentMatcher = new ComponentMatcher(_componentRepository);
            _entityFilterer = new EntityFilterer(_componentRepository, _componentMatcher);
            _systemRepository = new SystemRepository();
            _systemsExecuter = new SystemsExecuter(_systemRepository);
        }

        public Result Run(int entityCount, int frameCount)
        {
            var tpl = new Tpl();

            for (var i = 0; i < entityCount; i++)
            {
                _entityTemplateInstantiator.Instantiate(tpl);
            }

            _systemRepository.Register(new Sys(_entityFilterer, _componentRepository));

            var totalExecuteTime = MeasureExecute(frameCount, _systemsExecuter);

            return new Result(
                entityCount: entityCount,
                frameCount: frameCount,
                totalExecuteTime: totalExecuteTime);
        }

        private static TimeSpan MeasureExecute(int frameCount, ISystemsExecuter systemsExecuter)
        {
            var sw = Stopwatch.StartNew();

            for (var i = 0; i < frameCount; i++)
            {
                systemsExecuter.ExecuteAll();
            }

            sw.Stop();
            return sw.Elapsed;
        }
    }
}
