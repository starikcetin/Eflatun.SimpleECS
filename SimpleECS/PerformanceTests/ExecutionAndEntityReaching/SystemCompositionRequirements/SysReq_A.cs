using System;
using System.Collections.Generic;
using PerformanceTests.ExecutionAndEntityReaching.Components;
using SimpleECS.Interfaces;

namespace PerformanceTests.ExecutionAndEntityReaching.SystemCompositionRequirements
{
    public class SysReq_A : ISystemComponentRequirement
    {
        public IReadOnlyCollection<Type> RequiredComponentTypes { get; } = new[]
        {
            typeof(CoA)
        };
    }
}