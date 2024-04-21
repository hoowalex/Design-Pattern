namespace chain_of_responsibility
{
    class HighLevelHandler : SupportHandler
    {
        public override void HandleRequest(int level)
        {
            if (level <= 8)
            {
                Console.WriteLine("Welcome to High Support Level");
                Console.WriteLine("Solving your problem...");
                Console.WriteLine("The problem is solved!!!");
            }
            else if (nextHandler != null)
            {
                nextHandler.HandleRequest(level);
            }
            else
            {
                Console.WriteLine("Error: The problem level is maximum. We couldn't solve it.");
                Console.WriteLine("Try entering the problem level again:");
                level = Convert.ToInt32(Console.ReadLine());
                HandleRequest(level);
            }
        }
    }
}