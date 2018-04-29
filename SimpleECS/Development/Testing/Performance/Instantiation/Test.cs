using System;
using System.Diagnostics;
using SimpleECS.Interfaces;

namespace Development.Testing.Performance.Instantiation
{
    internal class Test
    {
        private readonly IEntityTemplateInstantiator _instantiator;

        public Test(IEntityTemplateInstantiator instantiator)
        {
            _instantiator = instantiator;
        }

        public Result Run(int entityCount, int componentPerEntity)
        {
            var templateCreationTime = MeasureEntityTemplateCreation(out var entityTemplate, componentPerEntity);
            var instantiationTime = MeasureInstantiation(entityCount, entityTemplate);

            return new Result(
                entityCount: entityCount,
                componentPerEntity: componentPerEntity,
                templateCreationTime: templateCreationTime,
                instantiationTime: instantiationTime);
        }

        private TimeSpan MeasureInstantiation(int entityCount, IEntityTemplate entityTemplate)
        {
            var sw = Stopwatch.StartNew();

            for (var i = 0; i < entityCount; i++)
            {
                _instantiator.Instantiate(entityTemplate);
            }

            sw.Stop();
            return sw.Elapsed;
        }

        private static TimeSpan MeasureEntityTemplateCreation(out EntityTemplate entityTemplate, int componentPerEntity)
        {
            var sw = Stopwatch.StartNew();

            entityTemplate = new EntityTemplate(componentPerEntity);

            sw.Stop();
            return sw.Elapsed;
        }
    }
}
