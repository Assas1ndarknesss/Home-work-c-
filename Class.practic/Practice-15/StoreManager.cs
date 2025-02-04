namespace Practice_15;

class StoreManager
{
     public List<Product> Products = new List<Product>();
     public void AddProduct(Product product){
        Products.Add(product);
     }
     public void GetProducts(){
        foreach (var item in Products)
        {
         System.Console.WriteLine($"Name: {item.GetName}, Price: {item.GetPrice}");   
         System.Console.WriteLine($"Quantity: {item.GetQuantity}");   
        }
     }

     public void GetProductByName(string name){
         foreach (var item in Products)
         {
            if (item.GetName()==name)
            {
         System.Console.WriteLine($"Name: {item.GetName}, Price: {item.GetPrice}");   
         System.Console.WriteLine($"Quantity: {item.GetQuantity}");   
            }
            else
            {
                System.Console.WriteLine("Don't finden");
            }
         }
     }
     
     public void RemoveProductByName(string name){
         foreach (var item in Products)
         {
            if (item.GetName()==name)
            {
                      Products.Remove(item);
            }
            else{
                System.Console.WriteLine("Don't finden");
            }
         }
     }

}