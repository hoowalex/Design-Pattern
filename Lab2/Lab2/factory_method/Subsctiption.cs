
namespace FactoryMethod
{
    public class Subscription : ISubscription
    {
        protected double monthlyFee;
        protected int minSubscriptionPeriod;
        protected List<string> channels;

        public Subscription(double monthlyFee, int minSubscriptionPeriod, List<string> channels)
        {
            this.monthlyFee = monthlyFee;
            this.minSubscriptionPeriod = minSubscriptionPeriod;
            this.channels = channels;
        }

        public double GetMonthlyFee()
        {
            return monthlyFee;
        }

        public void SetMonthlyFee(double monthlyFee)
        {
            this.monthlyFee = monthlyFee;
        }

        public int GetMinSubscriptionPeriod()
        {
            return minSubscriptionPeriod;
        }

        public void SetMinSubscriptionPeriod(int minSubscriptionPeriod)
        {
            this.minSubscriptionPeriod = minSubscriptionPeriod;
        }

        public List<string> GetChannels()
        {
            return channels;
        }

        public void SetChannels(List<string> channels)
        {
            this.channels = channels;
        }
    }
}