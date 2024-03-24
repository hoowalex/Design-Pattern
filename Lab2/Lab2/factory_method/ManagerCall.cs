namespace FactoryMethod
{
    public class ManagerCall : ISubscriptionFactory
    {
        public ISubscription CreateSubscription(double monthlyFee, int minPeriod, List<string> channels)
        {
            return new PremiumSubscription(monthlyFee, minPeriod, channels);
        }
    }
}