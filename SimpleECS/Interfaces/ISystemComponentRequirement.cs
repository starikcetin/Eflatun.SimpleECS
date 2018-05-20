using System;
using System.Collections.Generic;

namespace SimpleECS.Interfaces
{
    public interface ISystemComponentRequirement
    {
        IReadOnlyList<Type> RequiredComponentTypes { get; }
    }
}
