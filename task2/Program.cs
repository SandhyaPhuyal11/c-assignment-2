using System;

internal class Circle
{
    public const double PI = 3.14;

    public static double CalculateArea(double radius)
    {
        return PI * radius * radius;
    }

    public static double CalculatePerimeter(double radius)
    {
        return 2 * PI * radius;
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Task 2: Constants ---");

        double radius = 5;
        Console.WriteLine($"Area of circle: {Circle.CalculateArea(radius)}");
        Console.WriteLine($"Perimeter of circle: {Circle.CalculatePerimeter(radius)}");
    }
}