using System;
using System.Collections.Generic;
using Eflatun.SimpleECS.Core.Interfaces;

namespace Eflatun.SimpleECS.UnitTests.EntityFiltering
{
    internal class SystemComponentRequirement : ISystemComponentRequirement
    {
        public IReadOnlyList<Type> RequiredComponentTypes { get; } = new[]
        {
            typeof(Component)
        };
    }
}
