namespace money.save_money
{
    using money;

    public class SaveMoneyToLocaleStorage : SaveMoney
    {
        public void Save(Money money)
        {
            Console.Write("Save " + money.ToString() + " to local storage");
        }
    }
}