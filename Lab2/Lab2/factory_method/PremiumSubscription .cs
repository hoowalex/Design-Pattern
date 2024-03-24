namespace FactoryMethod
{
    public class PremiumSubscription : Subscription
    {
        public PremiumSubscription(double monthlyFee, int minSubscriptionPeriod, List<string> channels)
            : base(monthlyFee, minSubscriptionPeriod, channels)
        {
        }
    }
}