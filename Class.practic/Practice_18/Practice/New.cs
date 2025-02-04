public interface IVehicle
{
    void Drive();
    bool Refuel(int num);
}
public class Car : IVehicle
{
    public int FuelLevel;
    public bool IsRefuel;
    public Car(int Fuel)
    {
        this.FuelLevel = Fuel;
    }
    public void Drive()
    {
        if (FuelLevel > 0)
        {
            System.Console.WriteLine("In the road");
        }
        else
        {
            System.Console.WriteLine("Dont have Fuel");
        }
    }

    public bool Refuel(int num)
    {
        if (FuelLevel == 0)
        {
            FuelLevel += num;
        }
        return true;
    }
}

