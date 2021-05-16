using InterfacesTask.Items;

namespace InterfacesTask.Entities
{
    interface IHealer 
    {
        void Heal(Entity entity, IHeal heal);
    }
}