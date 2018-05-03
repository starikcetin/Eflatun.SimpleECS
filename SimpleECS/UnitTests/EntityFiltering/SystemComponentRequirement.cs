﻿using System;
using System.Collections.Generic;
using SimpleECS.Interfaces;

namespace UnitTests.EntityFiltering
{
    internal class SystemComponentRequirement : ISystemComponentRequirement
    {
        public IReadOnlyList<Type> RequiredComponentTypes { get; } = new[]
        {
            typeof(Component)
        };
    }
}
