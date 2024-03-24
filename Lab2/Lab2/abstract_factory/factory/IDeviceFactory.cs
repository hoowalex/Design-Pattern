namespace AbstractFactory.Factory
{
    public interface IDeviceFactory
    {
        Laptop CreateLaptop();

        Netbook CreateNetbook();

        EBook CreateEBook();

        Smartphone CreateSmartphone();
    }
}