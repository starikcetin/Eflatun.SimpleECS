using System.Collections.Generic;

namespace Eflatun.SimpleECS.Core.Interfaces
{
    public interface IEntityFilterer
    {
        IEnumerable<IEntity> GetCompatibleEntities(ISystemComponentRequirement systemComponentRequirement);
    }
}
