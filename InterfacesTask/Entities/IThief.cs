using InterfacesTask.Items;

namespace InterfacesTask.Entities
{
    interface IThief
    {
        void Get(Item item, Entity target);
    }
}