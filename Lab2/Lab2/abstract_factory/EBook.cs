namespace AbstractFactory
{
    public class EBook : IDevice
    {
        public new String GetType()
        {
            return "EBook";
        }
    }
}