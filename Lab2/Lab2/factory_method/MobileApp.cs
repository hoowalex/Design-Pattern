namespace FactoryMethod
{
    public class MobileApp : ISubscriptionFactory
    {
        public ISubscription CreateSubscription(double monthlyFee, int minPeriod, List<string> channels)
        {
            return new EducationalSubscription(monthlyFee, minPeriod, channels);
        }
    }
}