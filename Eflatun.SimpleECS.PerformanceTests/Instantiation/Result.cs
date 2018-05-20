using System;
using System.Text;

namespace Eflatun.SimpleECS.PerformanceTests.Instantiation
{
    internal class Result
    {
        public int EntityCount { get; }
        public int ComponentPerEntity { get; }
        public TimeSpan TemplateCreationTime { get; }
        public TimeSpan InstantiationTime { get; }

        public Result(int entityCount, int componentPerEntity, TimeSpan templateCreationTime, TimeSpan instantiationTime)
        {
            EntityCount = entityCount;
            ComponentPerEntity = componentPerEntity;
            TemplateCreationTime = templateCreationTime;
            InstantiationTime = instantiationTime;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("############");
            sb.AppendLine("Instantiation Performance Test");
            sb.AppendLine($"Entity Count       {EntityCount:N0}");
            sb.AppendLine($"Comp.s per Entity  {ComponentPerEntity:N0}");
            sb.AppendLine($"Template Creation  {TemplateCreationTime.TotalMilliseconds:N5} ms");
            sb.AppendLine($"Instantiation      {InstantiationTime.TotalMilliseconds:N5} ms");
            sb.AppendLine($"Instantiation Avg  {InstantiationTime.TotalMilliseconds / EntityCount:N5} ms");
            sb.AppendLine("############");
            return sb.ToString();
        }
    }
}
