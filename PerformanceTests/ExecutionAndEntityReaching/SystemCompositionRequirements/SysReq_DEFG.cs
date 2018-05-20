using System;
using System.Collections.Generic;
using PerformanceTests.ExecutionAndEntityReaching.Components;
using SimpleECS.Interfaces;

namespace PerformanceTests.ExecutionAndEntityReaching.SystemCompositionRequirements
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
