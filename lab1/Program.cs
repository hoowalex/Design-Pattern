using money;
using money.save_money;
using product;
using reporting;
using warehouse;

public class Program
{
    public static void Main()
    {

        Money money = new Dollar(100, 10);
        money.PrintAmount();

 
        SaveMoney saverMoney = new SaveMoneyToDataBase();
        saverMoney.Save(money);


        IProduct product = new Product("Product 1", money, "Some category");

        product.GetPrice().PrintAmount();


        IPriceReducible priceReducible = new PriceReducible();
        priceReducible.ReducePrice(money, product);

        product.GetPrice().PrintAmount();

        IInventoryReport inventoryReport = new InventoryReport();
        IProductsDispatch productsDispatch = new ProductsDispatch();
        IProductsReceipt productsReceipt = new ProductsReceipt();
        IReporting reporting = new Reporting();
        reporting.Report(productsReceipt, productsDispatch, inventoryReport);


        IWarehouse warehouse = new Warehouse("Measure", 11, money, "testname", "testcategory");
        productsReceipt.RegisterProductsReceipt(warehouse);
    }
}
