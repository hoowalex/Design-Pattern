namespace FactoryMethod
{
    public class WebSite : ISubscriptionFactory
    {
        public ISubscription CreateSubscription(double monthlyFee, int minPeriod, List<string> channels)
        {
            return new DomesticSubscription(monthlyFee, minPeriod, channels);
        }
    }
}