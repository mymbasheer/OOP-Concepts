// Usage
Vehicle myCar = new Car();
myCar.FuelUp();
myCar.Start();



// Abstract class
public abstract class Vehicle
{
    public abstract void Start(); // Abstract method (no implementation)

    public void FuelUp()
    {
        Console.WriteLine("The vehicle is refueling."); // Common functionality
    }
}

// Derived class
public class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("The car starts with a key.");
    }
}

