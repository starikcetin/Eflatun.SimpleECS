namespace SimpleECS.Interfaces
{
    public interface IComponentMatcher
    {
        bool IsMatching(IEntity entity, ISystemComponentRequirement systemComponentRequirement);
    }
}
