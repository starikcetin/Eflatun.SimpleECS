using SimpleECS.Interfaces;

namespace SimpleECS.Concretes
{
    public class EntityCreator : IEntityCreator
    {
        private readonly IUniqueIdProvider _uniqueIdProvider;

        public EntityCreator(IUniqueIdProvider uniqueIdProvider)
        {
            _uniqueIdProvider = uniqueIdProvider;
        }

        public Entity CreateEntity()
        {
            var id = _uniqueIdProvider.GetUniqueId();
            var entity = new Entity(id);
            return entity;
        }
    }
}
