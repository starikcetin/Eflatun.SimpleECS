using System;
using System.Collections.Generic;
using SimpleECS.Interfaces;
using StressTest.SingleSystemStressTest.Components;

namespace StressTest.SingleSystemStressTest.EntityTemplates
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
