namespace InterfacesTask.Items
{
    class Sword : Item, IWeapon
    {
        public int GetDamage()
        {
            return 10;
        }
    }
}