using money;
namespace warehouse;


public class Warehouse : IWarehouse {

    private String unitOfMeasure;
    private String name;
    private int quantity;
    private String category;
    private IMoney price;

    public Warehouse(String unitOfMeasure, int quantity, IMoney price, String name, String category) {
        this.unitOfMeasure = unitOfMeasure;
        this.quantity = quantity;
        this.price = price;
        this.name = name;
        this.category = category;
    }


    public String GetUnitOfMeasure() {
        return unitOfMeasure;
    }


    public void SetUnitOfMeasure(String unitOfMeasure) {
        this.unitOfMeasure = unitOfMeasure;
    }


    public int GetQuantity() {
        return quantity;
    }


    public void SetQuantity(int quantity) {
        this.quantity = quantity;
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