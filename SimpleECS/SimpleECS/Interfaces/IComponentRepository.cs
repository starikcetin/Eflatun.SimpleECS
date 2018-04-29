namespace SimpleECS.Interfaces
{
    public interface IComponentRepository
    {
        void Register(IEntity entity, IComponent component);
    }
}
