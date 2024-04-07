namespace decorator
{
    public class Paladin : Hero
    {
        public override void Display()
        {
            Console.WriteLine("Paladin");
        }

        public override void Attack()
        {
            Console.WriteLine("Paladin attacks the enemy");
        }
    }
}