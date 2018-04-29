using System.Collections.Generic;

namespace SimpleECS
{
    public interface IEntityCreator
    {
        IEnumerable<IComponent> CreateEntity(IEntityTemplate entityTemplate);
    }
}
