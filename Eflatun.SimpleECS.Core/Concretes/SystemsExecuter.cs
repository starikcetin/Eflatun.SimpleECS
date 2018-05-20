using Eflatun.SimpleECS.Core.Interfaces;

namespace Eflatun.SimpleECS.Core.Concretes
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
