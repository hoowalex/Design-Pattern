using product;
namespace warehouse;

public interface IWarehouse : IProduct {

    String GetUnitOfMeasure();

    void SetUnitOfMeasure(String unitOfMeasure);

    int GetQuantity();

    void SetQuantity(int quantity);
}