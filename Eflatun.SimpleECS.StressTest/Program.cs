using System;

namespace Eflatun.SimpleECS.StressTest
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var stress = new SingleSystemStressTest.Test().Run(
                entityCount: 100_000,
                frameCount: 50);

            Console.WriteLine(stress);
        }
    }
}
