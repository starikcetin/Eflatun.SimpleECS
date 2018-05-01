using System;
using System.Collections.Generic;
using SimpleECS.Interfaces;

namespace UnitTests.SystemComponentRequirementDefinition
{
    public class SystemComponentRequirementWithComponentA : ISystemComponentRequirement
    {
        public IReadOnlyCollection<Type> RequiredComponentTypes { get; } = new[]
        {
            typeof(ComponentA)
        };
    }
}
