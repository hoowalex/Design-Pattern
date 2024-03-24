namespace FactoryMethod
{
    public class DomesticSubscription : Subscription
    {
        public DomesticSubscription(double monthlyFee, int minSubscriptionPeriod, List<string> channels)
            : base(monthlyFee, minSubscriptionPeriod, channels)
        {

        }
    }
}