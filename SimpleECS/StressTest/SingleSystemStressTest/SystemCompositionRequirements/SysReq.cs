using System;
using System.Collections.Generic;
using SimpleECS.Interfaces;
using StressTest.SingleSystemStressTest.Components;

namespace StressTest.SingleSystemStressTest.SystemCompositionRequirements
{
    public class SysReq : ISystemComponentRequirement
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
