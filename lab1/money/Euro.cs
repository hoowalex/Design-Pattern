namespace money
{
    public class Euro : Money
    {
        public Euro(int wholeUnits, int cents) : base(wholeUnits, cents)
        {
        }

        public override void PrintAmount()
        {
            Console.WriteLine("Total amount in euro : " + GetWholePart() + "," + GetFractionalPart());
        }
    }

}

