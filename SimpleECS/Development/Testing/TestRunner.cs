using System;
using SimpleECS.Interfaces;

namespace Development.Testing
{
    internal class TestRunner
    {
        private readonly IEntityTemplateInstantiator _entityTemplateInstantiator;

        public TestRunner(IEntityTemplateInstantiator entityTemplateInstantiator)
        {
            _entityTemplateInstantiator = entityTemplateInstantiator;
        }

        public void RunAll()
        {
            var instantiation = new Performance.Instantiation.Test(_entityTemplateInstantiator).Run(
                        entityCount: 1_000,
                        componentPerEntity: 100);

            Console.WriteLine(instantiation);
        }
    }
}
