using SimpleECS.Concretes;

namespace SimpleECS.Interfaces
{
    public interface IEntityTemplateInstantiator
    {
        Entity Instantiate(IEntityTemplate entityTemplate);
    }
}
