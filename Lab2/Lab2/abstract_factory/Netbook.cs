namespace AbstractFactory
{
    public class Netbook : IDevice
    {
        public new String GetType()
        {
            return "Netbook";
        }
    }
}