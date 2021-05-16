using InterfacesTask.Items;

namespace InterfacesTask.Entities
{
    class Healer : Entity, IHealer
    {
        public void Heal(Entity entity, IHeal heal)
        {
            entity.Health += heal.GetEffect();
        }
    }
}