using System;

namespace Eflatun.SimpleECS.Core.Interfaces
{
    public interface IComponentCreator
    {
        IComponent CreateComponentFromType(Type componentType);
    }
}
