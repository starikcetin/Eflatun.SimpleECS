using Xunit;

namespace Eflatun.SimpleECS.UnitTests.SystemComponentRequirementDefinition
{
    public class Tests
    {
        [Fact]
        public void SystemComponentRequirement_Should_HaveComponentType_IfDefined()
        {
            // Prepare
            var scrWithComponentA = new SystemComponentRequirementWithComponentA();

            // Assert
            Assert.Contains(scrWithComponentA.RequiredComponentTypes, type => type == typeof(ComponentA));
        }

        [Fact]
        public void SystemComponentRequirement_ShouldNot_HaveComponentType_IfNotDefined()
        {
            // Prepare
            var scrWithComponentA = new SystemComponentRequirementWithComponentA();

            // Assert
            Assert.DoesNotContain(scrWithComponentA.RequiredComponentTypes, type => type == typeof(ComponentB));
        }
    }
}
