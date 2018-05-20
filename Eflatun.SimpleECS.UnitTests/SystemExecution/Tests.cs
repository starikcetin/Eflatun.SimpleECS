using Eflatun.SimpleECS.Core.Concretes;
using Xunit;

namespace Eflatun.SimpleECS.UnitTests.SystemExecution
{
    public class Tests
    {
        [Fact]
        public void ShouldNot_ExecuteSystem_WhenNeverRegistered()
        {
            // Prepare
            var systemsRepository = new SystemRepository();
            var systemsExecuter = new SystemsExecuter(systemsRepository);
            var system = new ExecutionCounterSystem();

            // Act
            systemsExecuter.ExecuteAll();

            // Assert
            Assert.Equal(system.ExecuteCounter, 0);
        }

        [Fact]
        public void Should_ExecuteSystem_WhenRegistered()
        {
            // Prepare
            var systemsRepository = new SystemRepository();
            var systemsExecuter = new SystemsExecuter(systemsRepository);
            var system = new ExecutionCounterSystem();

            // Act
            systemsRepository.Register(system);
            systemsExecuter.ExecuteAll();

            // Assert
            Assert.Equal(system.ExecuteCounter, 1);
        }

        [Fact]
        public void ShouldNot_ExecuteSystem_WhenUnregistered()
        {
            // Prepare
            var systemsRepository = new SystemRepository();
            var systemsExecuter = new SystemsExecuter(systemsRepository);
            var system = new ExecutionCounterSystem();

            // Act
            systemsRepository.Register(system);
            systemsRepository.Unregister(system);
            systemsExecuter.ExecuteAll();

            // Assert
            Assert.Equal(system.ExecuteCounter, 0);
        }
    }
}
