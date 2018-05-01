using System;
using System.Collections.Generic;
using PerformanceTests.ExecutionAndEntityReaching.Components;
using SimpleECS.Interfaces;

namespace PerformanceTests.ExecutionAndEntityReaching.SystemCompositionRequirements
{
    public class SysReq_BC : ISystemComponentRequirement
    {
        public IReadOnlyCollection<Type> RequiredComponentTypes { get; } = new[]
        {
            typeof(CoB),
            typeof(CoC)
        };
    }
}
