using System;

namespace SimpleECS.Interfaces
{
    public interface IComponentCreator
    {
        IComponent CreateComponentFromType(Type componentType);
    }
}
