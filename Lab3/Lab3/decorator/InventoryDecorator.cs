namespace decorator
{
    public abstract class InventoryDecorator : Hero
    {
        protected Hero hero;

        public InventoryDecorator(Hero hero)
        {
            this.hero = hero;
        }

        public override void Display()
        {
            hero.Display();
        }

        public override void Attack()
        {
            hero.Attack();
        }
    }
}