using SimpleECS.Interfaces;

namespace SimpleECS.Concretes
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
