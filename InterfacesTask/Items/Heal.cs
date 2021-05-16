namespace InterfacesTask.Items
{
    class Heal : Item, IHeal
    {
        public int GetEffect()
        {
            return 7;
        }
    }
}