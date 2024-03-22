using money;
namespace product;

public interface IPriceReducible
{
    void ReducePrice(IMoney money, IProduct product);
}
