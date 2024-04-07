namespace decorator
{
    public class Warrior : Hero
    {
        public override void Display()
        {
            Console.WriteLine("Warrior");
        }

        public override void Attack()
        {
            Console.WriteLine("Warrior attacks the enemy");
        }
    }
}