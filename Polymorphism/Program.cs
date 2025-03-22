// Usage
Shape shape1 = new Circle();
Shape shape2 = new Rectangle();
shape1.Draw();  // Output: Drawing a circle
shape2.Draw();  // Output: Drawing a rectangle



public class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape.");
    }
}

public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle.");
    }
}

public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a rectangle.");
    }
}

