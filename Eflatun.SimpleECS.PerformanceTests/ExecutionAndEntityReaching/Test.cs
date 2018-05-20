using System;
using System.Diagnostics;
using Eflatun.SimpleECS.Core.Concretes;
using Eflatun.SimpleECS.Core.Interfaces;
using Eflatun.SimpleECS.PerformanceTests.ExecutionAndEntityReaching.EntityTemplates;
using Eflatun.SimpleECS.PerformanceTests.ExecutionAndEntityReaching.Systems;

namespace Eflatun.SimpleECS.PerformanceTests.ExecutionAndEntityReaching
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

        public Result Run(int entityPerTemplate, int frameCount)
        {
            InitializeEntities(entityPerTemplate, _entityTemplateInstantiator);
            InitializeSystems(_systemRepository, _entityFilterer, _componentRepository);

            var totalExecuteTime = MeasureExecute(frameCount, _systemsExecuter);

            return new Result(
                templateCount: 4,
                entityPerTemplate: entityPerTemplate,
                frameCount: frameCount,
                totalExecuteTime: totalExecuteTime);
        }

        private static void InitializeEntities(int entityPerTemplate, IEntityTemplateInstantiator instantiator)
        {
            var a = new Tpl_A();
            var bc = new Tpl_BC();
            var defg = new Tpl_DEFG();
            var hijklmno = new Tpl_HIJK_LMNO();

            for (var i = 0; i < entityPerTemplate; i++)
            {
                instantiator.Instantiate(a);
                instantiator.Instantiate(bc);
                instantiator.Instantiate(defg);
                instantiator.Instantiate(hijklmno);
            }
        }

        private static void InitializeSystems(ISystemRepository systemRepository, IEntityFilterer entityFilterer,
            IComponentRepository componentRepository)
        {
            systemRepository.Register(new Sys_A(entityFilterer, componentRepository));
            systemRepository.Register(new Sys_BC(entityFilterer, componentRepository));
            systemRepository.Register(new Sys_DEFG(entityFilterer, componentRepository));
            systemRepository.Register(new Sys_HIJK_LMNO(entityFilterer, componentRepository));
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
