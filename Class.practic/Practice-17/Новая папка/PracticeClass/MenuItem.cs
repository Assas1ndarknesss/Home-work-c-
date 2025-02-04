namespace PracticeClass;

public class MenuItem
{
 private string Name;
 private double Price;
 private string Category;

 public MenuItem (string Name,double Price,string category){
    this.Name=Name;
    this.Price=Price;
    this.Category=category;
 }

 public string GetDescription(){
     return   $"Name: {this.Name}  Price: {this.Price} Category: {this.Category}";        
 }
}
