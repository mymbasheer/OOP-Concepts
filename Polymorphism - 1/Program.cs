// Usage
Calculator calc = new Calculator();
Console.WriteLine(calc.Add(5, 10));       // Output: 15
Console.WriteLine(calc.Add(5.5, 10.5));  // Output: 16.0


public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }
}

