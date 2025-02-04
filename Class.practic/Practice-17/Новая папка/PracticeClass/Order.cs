namespace PracticeClass;

public class Order
{
    private int OrderId;
    List<MenuItem> menuItems = new List<MenuItem>();
    private int TotalPrice;

    public Order(int OrderId){
        this.OrderId=OrderId;
    }
    public void AddItem(MenuItem item){
        menuItems.Add(item);
    }
    
    public void RemoveItem(MenuItem item){
        menuItems.Remove(item);
    }
    
    
}
