using System.Collections.Generic;

namespace SimpleECS.Interfaces
{
    public interface IEntityFilterer
    {
        IEnumerable<IEntity> GetCompatibleEntities(ISystemComponentRequirement systemComponentRequirement);
    }
}
