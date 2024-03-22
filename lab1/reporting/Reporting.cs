using System;

namespace reporting
{
    public class Reporting : IReporting
    {
        public void Report(IProductsReceipt productsReceipt, IProductsDispatch productsDispatch, IInventoryReport inventoryReport)
        {
            Console.WriteLine("Reporting");
        }
    }
}
