using System;
using SimpleECS.Interfaces;

namespace SimpleECS.Concretes
{
    public class ComponentCreator : IComponentCreator
    {
        public IComponent CreateComponentFromType(Type componentType)
        {
            return (IComponent) Activator.CreateInstance(componentType);
        }
    }
}
