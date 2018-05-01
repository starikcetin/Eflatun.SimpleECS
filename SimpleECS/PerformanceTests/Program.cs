using System;
using SimpleECS.Concretes;

namespace PerformanceTests
{
    internal static class Program
    {
        private static void Main()
        {
            var uniqueIdProvider = new UniqueIdProvider();
            var entityCreator = new EntityCreator(uniqueIdProvider);
            var componentCreator = new ComponentCreator();
            var componentRepository = new ComponentRepository();
            var entityTemplateInstantiator = new EntityTemplateInstantiator(entityCreator, componentCreator, componentRepository);
            
            var instantiation = new Instantiation.Test(entityTemplateInstantiator).Run(
                entityCount: 1_000,
                componentPerEntity: 100);

            Console.WriteLine(instantiation);

            var execute = new ExecutionAndEntityReaching.Test().Run(
                entityPerTemplate: 100,
                frameCount: 100);

            Console.WriteLine(execute);
        }
    }
}
