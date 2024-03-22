using money;
namespace product;

public class PriceReducible : IPriceReducible
{
    public void ReducePrice(IMoney money, IProduct product)
    {
        if (money.GetWholePart() < 0 || money.GetFractionalPart() < 0)
        {
            throw new Exception("Reduction amount must be a non-negative value");
        }

        IMoney currentSum = product.GetPrice();
        currentSum.SetMoney(currentSum.GetWholePart() - money.GetWholePart(), currentSum.GetFractionalPart() - money.GetFractionalPart());
        product.SetPrice(currentSum);
    }
}

