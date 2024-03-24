namespace FactoryMethod
{
    public class EducationalSubscription : Subscription
    {
        public EducationalSubscription(double monthlyFee, int minSubscriptionPeriod, List<string> channels)
            : base(monthlyFee, minSubscriptionPeriod, channels)
        {
        }
    }
}