namespace AbstractFactory.Factory
{
    public class XiaomiFactory : IDeviceFactory
    {
        public Laptop CreateLaptop()
        {
            return new Laptop();
        }

        public Netbook CreateNetbook()
        {
            return new Netbook();
        }

        public EBook CreateEBook()
        {
            return new EBook();
        }

        public Smartphone CreateSmartphone()
        {
            return new Smartphone();
        }
    }
}