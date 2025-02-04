namespace Practice_15;

public class Food : Product 
{
    private DateTime _ExpirationDate;
    public DateTime ExpirationDate
    {
        get { return this._ExpirationDate;}
        set{_ExpirationDate = value;}
    }
}
