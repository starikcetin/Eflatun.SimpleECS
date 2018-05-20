using System;
using System.Collections.Generic;
using Eflatun.SimpleECS.Core.Interfaces;
using Eflatun.SimpleECS.PerformanceTests.ExecutionAndEntityReaching.Components;

namespace Eflatun.SimpleECS.PerformanceTests.ExecutionAndEntityReaching.SystemCompositionRequirements
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
