using System;
using System.Collections.Generic;
using Eflatun.SimpleECS.Core.Interfaces;
using Eflatun.SimpleECS.PerformanceTests.ExecutionAndEntityReaching.Components;

namespace Eflatun.SimpleECS.PerformanceTests.ExecutionAndEntityReaching.SystemCompositionRequirements
{
    public class SysReq_DEFG : ISystemComponentRequirement
    {
        public IReadOnlyList<Type> RequiredComponentTypes { get; } = new[]
        {
            typeof(CoD),
            typeof(CoE),
            typeof(CoF),
            typeof(CoG)
        };
    }
}
