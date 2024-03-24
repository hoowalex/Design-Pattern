namespace FactoryMethod
{
    public interface ISubscription {

     double GetMonthlyFee();

     void SetMonthlyFee(double monthlyFee);

     int GetMinSubscriptionPeriod();

     void SetMinSubscriptionPeriod(int minSubscriptionPeriod);

     List<String> GetChannels();

     void SetChannels(List<String> channels);
}
}