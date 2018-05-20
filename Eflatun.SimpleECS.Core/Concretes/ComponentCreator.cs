using System;
using Eflatun.SimpleECS.Core.Interfaces;

namespace Eflatun.SimpleECS.Core.Concretes
{
    public class ComponentCreator : IComponentCreator
    {
        public IComponent CreateComponentFromType(Type componentType)
        {
            return (IComponent) Activator.CreateInstance(componentType);
        }
    }
}
