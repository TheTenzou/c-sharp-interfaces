using InterfacesTask.Items;

namespace InterfacesTask.Entities
{
    interface ITrader
    {
        void Get(Item item, Entity trader);

        void GaveAway(Item item, Entity trader);
    }
}