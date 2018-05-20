using System;
using System.Text;

namespace PerformanceTests.ExecutionAndEntityReaching
{
    internal struct Result
    {
        public int EntityPerTemplate { get; }
        public int TemplateCount { get; }
        public int FrameCount { get; }
        public TimeSpan TotalExecuteTime { get; }

        public Result(int templateCount, int entityPerTemplate, int frameCount, TimeSpan totalExecuteTime)
        {
            EntityPerTemplate = entityPerTemplate;
            TemplateCount = templateCount;
            FrameCount = frameCount;
            TotalExecuteTime = totalExecuteTime;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("############");
            sb.AppendLine("Execution and Entity Reaching Performance Test");
            sb.AppendLine($"Entity Per Templ.  {EntityPerTemplate:N0}");
            sb.AppendLine($"Template Count     {TemplateCount:N0}");
            sb.AppendLine($"Total Entities     {TemplateCount*EntityPerTemplate:N0}");
            sb.AppendLine($"Frame Count        {FrameCount:N0}");
            sb.AppendLine($"Total              {TotalExecuteTime.TotalMilliseconds:N5} ms");
            sb.AppendLine($"Frame Avg          {TotalExecuteTime.TotalMilliseconds / FrameCount:N5} ms");
            sb.AppendLine("############");
            return sb.ToString();
        }
    }
}
