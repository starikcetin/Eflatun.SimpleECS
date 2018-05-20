namespace Eflatun.SimpleECS.Core.Interfaces
{
    public interface IComponentMatcher
    {
        bool IsMatching(IEntity entity, ISystemComponentRequirement systemComponentRequirement);
    }
}
