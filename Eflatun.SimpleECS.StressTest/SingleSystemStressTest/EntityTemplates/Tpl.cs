using System;
using System.Collections.Generic;
using Eflatun.SimpleECS.Core.Interfaces;
using Eflatun.SimpleECS.StressTest.SingleSystemStressTest.Components;

namespace Eflatun.SimpleECS.StressTest.SingleSystemStressTest.EntityTemplates
{
    internal class Tpl : IEntityTemplate
    {
        public IEnumerable<Type> ComponentTypes { get; } = new[]
        {
            typeof(CoA),
            typeof(CoB),
            typeof(CoC),
            typeof(CoD),
            typeof(CoE),
            typeof(CoF),
            typeof(CoG),

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
