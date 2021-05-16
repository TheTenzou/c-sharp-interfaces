using InterfacesTask.Items;

namespace InterfacesTask.Entities
{
    class Warrior : Entity, IWarrior
    {
        public void Attack(Entity entity, IWeapon weapon)
        {
            entity.Health -= weapon.GetDamage();
        }
    }
}