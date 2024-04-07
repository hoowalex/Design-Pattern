namespace decorator
{
    public class Mage : Hero
    {
        public override void Display()
        {
            Console.WriteLine("Mage");
        }

        public override void Attack()
        {
            Console.WriteLine("Mage attacks the enemy");
        }
    }
}