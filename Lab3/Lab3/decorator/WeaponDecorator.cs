namespace decorator
{
    public class WeaponDecorator : InventoryDecorator
    {
        public WeaponDecorator(Hero hero) : base(hero) { }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Weapon equipment");
        }
    }
}