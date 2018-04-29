using Development.Testing;
using SimpleECS.Concretes;

namespace Development
{
    internal static class Program
    {
        private static void Main()
        {
            var uniqueIdProvider = new UniqueIdProvider();
            var componentCreator = new ComponentCreator();
            var componentRepository = new ComponentRepository();
            var entityCreator = new EntityCreator(uniqueIdProvider);
            var entityTemplateInstantiator =
                new EntityTemplateInstantiator(entityCreator, componentCreator, componentRepository);

            var testRunner = new TestRunner(entityTemplateInstantiator);
            testRunner.RunAll();
        }
    }
}
