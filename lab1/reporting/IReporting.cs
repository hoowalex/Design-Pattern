namespace reporting
{

    public interface IReporting
    {

        void Report(IProductsReceipt productsReceipt, IProductsDispatch productsDispatch, IInventoryReport inventoryReport);


    }
}