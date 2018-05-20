using Eflatun.SimpleECS.Core.Interfaces;

namespace Eflatun.SimpleECS.Core.Concretes
{
    public class UniqueIdProvider : IUniqueIdProvider
    {
        private int _lastReturnedId = 0;

        public int GetUniqueId()
        {
            return _lastReturnedId++;
        }
    }
}
