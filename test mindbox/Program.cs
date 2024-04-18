Circle circle = new Circle(5);
double circleArea = circle.CalculateArea();
Console.WriteLine($"Circle Area: {circleArea}");

Triangle triangle = new Triangle(3, 4, 5);
double triangleArea = triangle.CalculateArea();
Console.WriteLine($"Triangle Area: {triangleArea}");

double unknownShapeArea = UnknownShape.CalculateArea(circle);
Console.WriteLine($"UnknownShape Area: {unknownShapeArea}");

public class Circle : IShape
{
    public Circle(double radius)
    {
        Radius = Math.Abs(radius);
    }
    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
    public double Radius;
}

public class Triangle : IShape
{
    public Triangle(double side1, double side2, double side3)
    {
        Side1 = Math.Abs(side1);
        Side2 = Math.Abs(side2);
        Side3 = Math.Abs(side3);
    }
    public double CalculateArea()
    {
        double s = (Side1 + Side2 + Side3) / 2;
        return Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3));
    }
    public bool IsTriangleRight()
    {
        var array = new double[] { Side1, Side2, Side3 };
        var maxSide = array.Max();
        double temp = 0;
        for (int i = 0; i < array.Length; i++)
            if (array[i] != maxSide)
                temp += array[i] * array[i];

        return temp == maxSide * maxSide ? true : false;
    }
    public double Side1;
    public double Side2;
    public double Side3;
}

public interface IShape
{
    double CalculateArea();
}

public class UnknownShape
{
    public static double CalculateArea(IShape shape)
    {
        return shape.CalculateArea();
    }
}