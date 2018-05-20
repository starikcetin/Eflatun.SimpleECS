using System.Collections.Generic;
using Eflatun.SimpleECS.Core.Interfaces;

namespace Eflatun.SimpleECS.Core.Concretes
{
    public class SystemRepository : ISystemRepository
    {
        private readonly HashSet<ISystem> _systems = new HashSet<ISystem>();
        public IReadOnlyCollection<ISystem> RegisteredSystems => _systems;

        public void Register(ISystem system)
        {
            _systems.Add(system);
        }

        public void Unregister(ISystem system)
        {
            _systems.Remove(system);
        }
    }
}
