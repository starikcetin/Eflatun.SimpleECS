using System;
using System.Collections.Generic;
using Eflatun.SimpleECS.Core.Interfaces;
using Eflatun.SimpleECS.StressTest.SingleSystemStressTest.Components;

namespace Eflatun.SimpleECS.StressTest.SingleSystemStressTest.SystemCompositionRequirements
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
