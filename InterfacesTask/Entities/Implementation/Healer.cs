using InterfacesTask.Items;

namespace InterfacesTask.Entities.Implementaion
{
    class Healer : Entity, IHealer
    {
        public void Heal(Entity entity, IHeal heal)
        {
            entity.Health += heal.GetEffect();
        }
    }
}