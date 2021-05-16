using System.Collections.Generic;

using InterfacesTask.Items;

namespace InterfacesTask.Entities
{
    class Entity
    {
        public int Health { set; get; }

        public int CarryWeight { set; get; }

        public int Wallet { set; get; }

        public List<Item> ItemList { set; get; }
    }
}