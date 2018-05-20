using System.Collections.Generic;

namespace Eflatun.SimpleECS.Core.Interfaces
{
    public interface ISystemRepository
    {
        IReadOnlyCollection<ISystem> RegisteredSystems { get; }
        void Register(ISystem system);
        void Unregister(ISystem system);
    }
}
