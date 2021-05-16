using InterfacesTask.Items;

namespace InterfacesTask.Entities.Implementaion
{
    class Trader : Entity, ITrader
    {
        public void GaveAway(Item item, Entity trader)
        {
            trader.ItemList.Add(item);
            this.ItemList.Remove(item);
            this.Wallet += item.Price;
            trader.Wallet -= item.Price;
        }

        public void Get(Item item, Entity trader)
        {
            trader.ItemList.Remove(item);
            this.ItemList.Add(item);
            this.Wallet -= item.Price;
            trader.Wallet += item.Price;
        }
    }
}