using System;
using System.Collections.Generic;
using PerformanceTests.ExecutionAndEntityReaching.Components;
using SimpleECS.Interfaces;

namespace PerformanceTests.ExecutionAndEntityReaching.EntityTemplates
{
    internal class Tpl_DEFG : IEntityTemplate
    {
        public IEnumerable<Type> ComponentTypes { get; } = new[]
        {
            typeof(CoD),
            typeof(CoE),
            typeof(CoF),
            typeof(CoG)
        };
    }
}