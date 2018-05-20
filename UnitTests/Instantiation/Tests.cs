using System.Collections.Generic;
using SimpleECS.Concretes;
using SimpleECS.Interfaces;
using Xunit;

namespace UnitTests.Instantiation
{
    public class InstantiatedEntitySignatureTests
    {
        [Fact]
        public void Entity_Should_HaveComponentsDefinedInTemplate_WhenInstantiated()
        {
            // Prepare
            var uniqueIdProvider = new UniqueIdProvider();
            var componentRepository = new ComponentRepository();
            var componentCreator = new ComponentCreator();
            var entityCreator = new EntityCreator(uniqueIdProvider);
            var entityTemplateInstantiator =
                new EntityTemplateInstantiator(entityCreator, componentCreator, componentRepository);

            var entityTemplateWithComponentA = new EntityTemplateWithComponentA();

            // Act
            var entityWithComponentA = entityTemplateInstantiator.Instantiate(entityTemplateWithComponentA);

            // Assert
            IReadOnlyCollection<IComponent> components = componentRepository.GetComponents(entityWithComponentA);
            Assert.Contains(components, component => component.GetType() == typeof(ComponentA));
        }

        [Fact]
        public void Entity_ShouldNot_HaveComponentsNotDefinedInTemplate_WhenInstantiated()
        {
            // Prepare
            var uniqueIdProvider = new UniqueIdProvider();
            var componentRepository = new ComponentRepository();
            var componentCreator = new ComponentCreator();
            var entityCreator = new EntityCreator(uniqueIdProvider);
            var entityTemplateInstantiator =
                new EntityTemplateInstantiator(entityCreator, componentCreator, componentRepository);

            var entityTemplateWithComponentA = new EntityTemplateWithComponentA();

            // Act
            var entityWithComponentA = entityTemplateInstantiator.Instantiate(entityTemplateWithComponentA);

            // Assert
            IReadOnlyCollection<IComponent> components = componentRepository.GetComponents(entityWithComponentA);
            Assert.DoesNotContain(components, component => component.GetType() == typeof(ComponentB));
        }
    }
}
