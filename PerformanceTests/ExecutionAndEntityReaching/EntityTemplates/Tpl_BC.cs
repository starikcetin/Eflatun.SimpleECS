using System;
using System.Collections.Generic;
using PerformanceTests.ExecutionAndEntityReaching.Components;
using SimpleECS.Interfaces;

namespace PerformanceTests.ExecutionAndEntityReaching.EntityTemplates
{
    internal class Tpl_BC : IEntityTemplate
    {
        public IEnumerable<Type> ComponentTypes { get; } = new[]
        {
            typeof(CoB),
            typeof(CoC)
        };
    }
}