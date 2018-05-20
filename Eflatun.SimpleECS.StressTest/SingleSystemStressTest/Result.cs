using System;
using System.Text;

namespace Eflatun.SimpleECS.StressTest.SingleSystemStressTest
{
    internal struct Result
    {
        public int EntityCount { get; }
        public int FrameCount { get; }
        public TimeSpan TotalExecuteTime { get; }

        public Result(int entityCount, int frameCount, TimeSpan totalExecuteTime)
        {
            EntityCount = entityCount;
            FrameCount = frameCount;
            TotalExecuteTime = totalExecuteTime;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("############");
            sb.AppendLine("Single System Stress Test");
            sb.AppendLine($"Entity Count       {EntityCount:N0}");
            sb.AppendLine($"Frame Count        {FrameCount:N0}");
            sb.AppendLine($"Total              {TotalExecuteTime.TotalMilliseconds:N5} ms");
            sb.AppendLine($"Frame Avg          {TotalExecuteTime.TotalMilliseconds / FrameCount:N5} ms");
            sb.AppendLine("############");
            return sb.ToString();
        }
    }
}
