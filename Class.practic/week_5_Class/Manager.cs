public class Manager
{
    public List<Post> GetPosts = new List<Post>();
    public List<Category> categories = new List<Category>();
    public List<Post> Getpost()
    {
        return GetPosts;
    }

    public Post GetpostById(int id)
    {
        foreach (var item in GetPosts)
        {
            if (item.Id == id)
            {
                return item;
            }
        }
        return null;
    }
    


}