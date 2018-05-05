using System;
using System.Collections.Generic;
using PerformanceTests.ExecutionAndEntityReaching.Components;
using SimpleECS.Interfaces;

namespace PerformanceTests.ExecutionAndEntityReaching.SystemCompositionRequirements
{
    public class SysReq_A : ISystemComponentRequirement
    {
        public IReadOnlyList<Type> RequiredComponentTypes { get; } = new[]
        {
            typeof(CoA)
        };
    }
}
