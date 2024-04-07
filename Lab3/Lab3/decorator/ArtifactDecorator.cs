namespace decorator
{
    public class ArtifactDecorator : InventoryDecorator
    {
        public ArtifactDecorator(Hero hero) : base(hero) { }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Artifact equipment");
        }
    }
}