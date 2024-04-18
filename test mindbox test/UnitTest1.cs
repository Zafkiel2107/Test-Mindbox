public class CircleTest
{
    [Theory]
    [InlineData(-5)]
    public void CircleAreaCalculation(double radius)
    {
        // Arrange
        Circle circle = new Circle(radius);

        // Act
        double area = circle.CalculateArea();

        // Assert
        Assert.Equal(Math.PI * 5 * 5, area);
    }
}
public class TriangleTest
{
    [Theory]
    [InlineData(3, 4, -5)]
    public void TriangleAreaCalculation(double side1, double side2, double side3)
    {
        // Arrange
        Triangle triangle = new Triangle(side1, side2, side3);

        // Act
        double area = triangle.CalculateArea();

        // Assert
        Assert.Equal(6, area);
    }

    [Theory]
    [InlineData(3, 4, -5)]
    public void RightTriangleCheck(double side1, double side2, double side3)
    {
        // Arrange
        Triangle triangle = new Triangle(side1, side2, side3);

        // Act
        bool isRightTriangle = triangle.IsTriangleRight();

        // Assert
        Assert.True(isRightTriangle);
    }
}

public class UnknownShapeTest
{
    [Theory]
    [InlineData(3, 4, -5)]
    public void TriangleAreaCalculation(double side1, double side2, double side3)
    {
        // Arrange
        Triangle triangle = new Triangle(side1, side2, side3);

        // Act
        double area = UnknownShape.CalculateArea(triangle);

        // Assert
        Assert.Equal(6, area);
    }
}