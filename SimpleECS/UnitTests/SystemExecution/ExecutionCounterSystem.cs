using SimpleECS.Interfaces;

namespace UnitTests.SystemExecution
{
    internal class ExecutionCounterSystem : ISystem
    {
        public int ExecuteCounter { get; private set; } = 0;

        public void Execute()
        {
            ExecuteCounter++;
        }
    }
}
