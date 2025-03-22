// Usage
Dog myDog = new Dog();
myDog.Eat();  // Inherited method
myDog.Bark(); // Child-specific method




// Parent class
public class Animal
{
    public void Eat()
    {
        Console.WriteLine("This animal eats food.");
    }
}

// Child class inheriting from Animal
public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("The dog barks.");
    }
}

