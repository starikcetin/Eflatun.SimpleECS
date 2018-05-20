using System;
using System.Collections.Generic;
using SimpleECS.Interfaces;

namespace UnitTests.SystemComponentRequirementDefinition
{
    public class SystemComponentRequirementWithComponentA : ISystemComponentRequirement
    {
        public IReadOnlyList<Type> RequiredComponentTypes { get; } = new[]
        {
            typeof(ComponentA)
        };
    }
}
