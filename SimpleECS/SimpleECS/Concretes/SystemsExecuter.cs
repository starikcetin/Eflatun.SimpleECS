using System.Collections.Generic;
using SimpleECS.Interfaces;

namespace SimpleECS.Concretes
{
    public class SystemsExecuter : ISystemsExecuter
    {
        private readonly ISystemRepository _systemRepository;

        public SystemsExecuter(ISystemRepository systemRepository)
        {
            _systemRepository = systemRepository;
        }

        public void ExecuteAll()
        {
            foreach (var system in _systemRepository.RegisteredSystems)
            {
                system.Execute();
            }
        }
    }
}
