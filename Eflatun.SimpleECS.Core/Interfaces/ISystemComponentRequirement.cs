using System;
using System.Collections.Generic;

namespace Eflatun.SimpleECS.Core.Interfaces
{
    public interface ISystemComponentRequirement
    {
        IReadOnlyList<Type> RequiredComponentTypes { get; }
    }
}
