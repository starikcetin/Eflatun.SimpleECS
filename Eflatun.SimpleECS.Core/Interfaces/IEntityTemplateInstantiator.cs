using Eflatun.SimpleECS.Core.Concretes;

namespace Eflatun.SimpleECS.Core.Interfaces
{
    public interface IEntityTemplateInstantiator
    {
        Entity Instantiate(IEntityTemplate entityTemplate);
    }
}
