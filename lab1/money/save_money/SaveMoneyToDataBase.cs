namespace money.save_money
{
    using money;

    public class SaveMoneyToDataBase : SaveMoney
    {
        public void Save(Money money)
        {
            Console.Write("Save " + money.ToString() + " to database");
        }
    }
}
