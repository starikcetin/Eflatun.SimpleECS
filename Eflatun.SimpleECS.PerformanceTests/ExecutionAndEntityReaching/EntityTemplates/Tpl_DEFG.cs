using System;
using System.Collections.Generic;
using Eflatun.SimpleECS.Core.Interfaces;
using Eflatun.SimpleECS.PerformanceTests.ExecutionAndEntityReaching.Components;

namespace Eflatun.SimpleECS.PerformanceTests.ExecutionAndEntityReaching.EntityTemplates
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
