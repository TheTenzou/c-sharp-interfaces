using InterfacesTask.Items;

namespace InterfacesTask.Entities
{
    interface IWarrior
    {
        void Attack(Entity entity, IWeapon weapon);
    }
}