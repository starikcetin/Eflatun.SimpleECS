using System;
using System.Collections.Generic;
using Eflatun.SimpleECS.Core.Interfaces;

namespace Eflatun.SimpleECS.UnitTests.SystemComponentRequirementDefinition
{
    public class SystemComponentRequirementWithComponentA : ISystemComponentRequirement
    {
        public IReadOnlyList<Type> RequiredComponentTypes { get; } = new[]
        {
            typeof(ComponentA)
        };
    }
}
