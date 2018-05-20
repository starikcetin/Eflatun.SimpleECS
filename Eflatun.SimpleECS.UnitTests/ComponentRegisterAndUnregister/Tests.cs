using System.Collections.Generic;
using Eflatun.SimpleECS.Core.Concretes;
using Eflatun.SimpleECS.Core.Interfaces;
using Xunit;

namespace Eflatun.SimpleECS.UnitTests.ComponentRegisterAndUnregister
{
    public class InstantiatedEntitySignatureTests
    {
        [Fact]
        public void Entity_Should_HaveComponent_WhenRegistered()
        {
            // Prepare
            var uniqueIdProvider = new UniqueIdProvider();
            var componentRepository = new ComponentRepository();
            var componentCreator = new ComponentCreator();
            var entityCreator = new EntityCreator(uniqueIdProvider);
            var entityTemplateInstantiator =
                new EntityTemplateInstantiator(entityCreator, componentCreator, componentRepository);

            var emptyEntityTemplate = new EmptyEntityTemplate();

            // Act
            var entity = entityTemplateInstantiator.Instantiate(emptyEntityTemplate);
            var component = new Component();
            componentRepository.Register(entity, component);

            // Assert
            IReadOnlyCollection<IComponent> components = componentRepository.GetComponents(entity);
            Assert.Contains(components, c => c == component);
        }

        [Fact]
        public void Entity_ShouldNot_HaveComponent_WhenUnregistered()
        {
            // Prepare
            var uniqueIdProvider = new UniqueIdProvider();
            var componentRepository = new ComponentRepository();
            var componentCreator = new ComponentCreator();
            var entityCreator = new EntityCreator(uniqueIdProvider);
            var entityTemplateInstantiator =
                new EntityTemplateInstantiator(entityCreator, componentCreator, componentRepository);

            var entityTemplateWithComponent = new EntityTemplateWithComponent();

            // Act
            var entity = entityTemplateInstantiator.Instantiate(entityTemplateWithComponent);
            var component = componentRepository.GetComponent<Component>(entity);
            componentRepository.Unregister(entity, component);

            // Assert
            IReadOnlyCollection<IComponent> components = componentRepository.GetComponents(entity);
            Assert.DoesNotContain(components, c => c == component);
        }
    }
}
