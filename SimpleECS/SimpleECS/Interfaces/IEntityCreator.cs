using System.Collections.Generic;

namespace SimpleECS.Interfaces
{
    public interface IEntityCreator
    {
        IEnumerable<IComponent> CreateEntity(IEntityTemplate entityTemplate);
    }
}
