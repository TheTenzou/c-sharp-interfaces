using InterfacesTask.Items;

namespace InterfacesTask.Entities
{
    class Thief : Entity, IThief
    {
        public void Get(Item item, Entity target)
        {
            target.ItemList.Remove(item);
            this.ItemList.Add(item);
        }
    }
}