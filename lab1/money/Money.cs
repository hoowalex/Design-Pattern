namespace money
{
    public class Money : IMoney
    {
        private int wholePart;
        private int fractionalPart;

        public Money(int wholeUnits, int cents)
        {
            this.wholePart = wholeUnits;
            this.fractionalPart = cents;
        }

        public int GetWholePart()
        {
            return wholePart;
        }

        public int GetFractionalPart()
        {
            return fractionalPart;
        }

        public void SetMoney(int wholePart, int fractionalPart)
        {
            this.wholePart = wholePart;
            this.fractionalPart = fractionalPart;
        }

        public virtual void PrintAmount()
        {
            Console.Write($"Total amount: {wholePart},{fractionalPart}");
        }
    }
}
