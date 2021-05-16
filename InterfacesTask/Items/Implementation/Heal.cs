namespace InterfacesTask.Items.Implementaion
{
    class Heal : Item, IHeal
    {
        public int GetEffect()
        {
            return 7;
        }
    }
}