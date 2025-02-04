public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime CreatedAt { get; set; }
    public Category(string Name)
    {
        this.Name = Name;
    }


}