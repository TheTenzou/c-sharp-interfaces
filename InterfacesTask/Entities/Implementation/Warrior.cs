using InterfacesTask.Items;

namespace InterfacesTask.Entities.Implementaion
{
    class Warrior : Entity, IWarrior
    {
        public void Attack(Entity entity, IWeapon weapon)
        {
            entity.Health -= weapon.GetDamage();
        }
    }
}