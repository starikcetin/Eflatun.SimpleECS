using System.Collections.Generic;
using SimpleECS.Interfaces;

namespace SimpleECS.Concretes
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
