namespace decorator
{
    public class ClothingDecorator : InventoryDecorator
    {
        public ClothingDecorator(Hero hero) : base(hero) { }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Clothing equipment");
        }
    }
}