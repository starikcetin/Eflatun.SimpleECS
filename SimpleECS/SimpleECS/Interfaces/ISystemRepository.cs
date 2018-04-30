using System.Collections.Generic;

namespace SimpleECS.Interfaces
{
    public interface ISystemRepository
    {
        IReadOnlyCollection<ISystem> RegisteredSystems { get; }
        void Register(ISystem system);
        void Unregister(ISystem system);
    }
}
