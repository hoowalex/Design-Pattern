namespace money
{
    public class Dollar : Money
    {
        public Dollar(int wholeUnits, int cents) : base(wholeUnits, cents)
        {
        }

        public override void PrintAmount()
        {
            Console.WriteLine("Total amount in dollar : " + GetWholePart() + "," + GetFractionalPart());
        }
    }
}
