namespace AbstractFactory
{
    public class Laptop : IDevice
    {
        public new String GetType()
        {
            return "Laptop";
        }
    }
}