using System;
using System.Collections.Generic;
using PerformanceTests.ExecutionAndEntityReaching.Components;
using SimpleECS.Interfaces;

namespace PerformanceTests.ExecutionAndEntityReaching.SystemCompositionRequirements
{
    public class SysReq_HIJK_LMNO : ISystemComponentRequirement
    {
        public IReadOnlyList<Type> RequiredComponentTypes { get; } = new[]
        {
            typeof(CoH),
            typeof(CoI),
            typeof(CoJ),
            typeof(CoK),
            typeof(CoL),
            typeof(CoM),
            typeof(CoN),
            typeof(CoO)
        };
    }
}
