using money;
namespace product;

public interface IProduct {

    IMoney GetPrice();

    void SetPrice(IMoney money);

    String GetName();

    void SetName(String name);

    void SetCategory(String category);

    String GetCategory();

}
