using Xunit;

namespace UnitTests.TemplateDefinition
{
    public class TemplateDefinitionTests
    {
        [Fact]
        public void EntityTemplate_Should_HaveComponentType_WhenDefined()
        {
            // Prepare
            var entityTemplateWithComponentA = new EntityTemplateWithComponentA();

            // Act

            // Assert
            Assert.Contains(entityTemplateWithComponentA.ComponentTypes, type => type == typeof(ComponentA));
        }

        [Fact]
        public void EntityTemplate_ShouldNot_HaveComponentType_WhenNotDefined()
        {
            // Prepare
            var entityTemplateWithComponentA = new EntityTemplateWithComponentA();

            // Act

            // Assert
            Assert.DoesNotContain(entityTemplateWithComponentA.ComponentTypes, type => type == typeof(ComponentB));
        }
    }
}
