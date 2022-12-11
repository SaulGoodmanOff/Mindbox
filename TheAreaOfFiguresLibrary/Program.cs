using TheAreaOfFiguresLibrary;
public class Program
{
    private static void Main(string[] args)
    {        
        Triangle triangle = new Triangle(5, 7, 8);
        Console.WriteLine(triangle.Square());
        Circle circle = new Circle(10);
        Console.WriteLine(circle.Square());
    }
}