namespace InterfacesTask.Items.Implementaion
{
    class Sword : Item, IWeapon
    {
        public int GetDamage()
        {
            return 10;
        }
    }
}