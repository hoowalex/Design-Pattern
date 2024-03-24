namespace FactoryMethod
{
    public interface ISubscriptionFactory
    {
        ISubscription CreateSubscription(double monthlyFee, int minPeriod, List<string> channels);
    }

}