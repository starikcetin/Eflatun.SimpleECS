using System;
using System.Collections.Generic;

namespace SimpleECS.Interfaces
{
    public interface ISystemComponentRequirement
    {
        IReadOnlyCollection<Type> RequiredComponentTypes { get; }
    }
}
