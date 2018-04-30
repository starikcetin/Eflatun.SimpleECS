using System.Linq;
using SimpleECS.Concretes;
using Xunit;

namespace UnitTests.EntityFiltering
{
    public class Tests
    {
        [Fact]
        public void EntityFilterer_Should_ConsiderEntity_WhenMatches()
        {
            // Prepare
            var uniqueIdProvider = new UniqueIdProvider();
            var componentRepository = new ComponentRepository();
            var componentMatcher = new ComponentMatcher(componentRepository);
            var entityFilterer = new EntityFilterer(componentRepository, componentMatcher);
            var entityCreator = new EntityCreator(uniqueIdProvider);
            var systemCompositionRequirement = new SystemComponentRequirement();

            // Act
            var entityA = entityCreator.CreateEntity();
            var compA = new Component();
            componentRepository.Register(entityA, compA);

            var entityB = entityCreator.CreateEntity();
            var compB = new Component();
            componentRepository.Register(entityB, compB);

            var entityC = entityCreator.CreateEntity();
            componentRepository.Register(entityC);

            var entityD = entityCreator.CreateEntity();
            componentRepository.Register(entityD);

            var matchingEntities = entityFilterer.GetCompatibleEntities(systemCompositionRequirement).ToArray();

            // Assert
            Assert.Contains(matchingEntities, e => e == entityA);
            Assert.Contains(matchingEntities, e => e == entityB);
        }

        [Fact]
        public void EntityFilterer_ShouldNot_ConsiderEntity_WhenNotMatches()
        {
            // Prepare
            var uniqueIdProvider = new UniqueIdProvider();
            var componentRepository = new ComponentRepository();
            var componentMatcher = new ComponentMatcher(componentRepository);
            var entityFilterer = new EntityFilterer(componentRepository, componentMatcher);
            var entityCreator = new EntityCreator(uniqueIdProvider);
            var systemCompositionRequirement = new SystemComponentRequirement();

            // Act
            var entityA = entityCreator.CreateEntity();
            var compA = new Component();
            componentRepository.Register(entityA, compA);

            var entityB = entityCreator.CreateEntity();
            var compB = new Component();
            componentRepository.Register(entityB, compB);

            var entityC = entityCreator.CreateEntity();
            componentRepository.Register(entityC);

            var entityD = entityCreator.CreateEntity();
            componentRepository.Register(entityD);

            var matchingEntities = entityFilterer.GetCompatibleEntities(systemCompositionRequirement).ToArray();

            // Assert
            Assert.DoesNotContain(matchingEntities, e => e == entityC);
            Assert.DoesNotContain(matchingEntities, e => e == entityD);
        }
    }
}
