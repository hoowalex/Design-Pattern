using money;
namespace product;

public class Product : IProduct {
    private String name;
    private IMoney price;
    private String category;

    public Product(String name, IMoney price, String category) {
        this.category = category;
        this.name = name;
        this.price = price;
    }

    public IMoney GetPrice() {
        return price;
    }

    public void SetPrice(IMoney money) {
        this.price = money;
    }

    public String GetName() {
        return name;
    }

    public void SetName(String name) {
        this.name = name;
    }

  
    public void SetCategory(String category) {
        this.category = category;
    }

    public String GetCategory() {
        return category;
    }

}