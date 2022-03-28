using System;
using Xunit;

namespace Shapes.Tests;

public class TriangleTests
{
    [Theory]
    [InlineData(2, 6, 7, 5.56)]
    [InlineData(12.2, 4.1, 9.4, 15.88)]
    [InlineData(12, 4.1, 9.4, 16.65)]
    [InlineData(3, 4, 5, 6)]
    public void GetArea_ReturnsRightValue_ForDifferentSides(double sideA, double sideB, double sideC, double expected)
    {
        var triangle = new Triangle(sideA, sideB, sideC);

        var area = Math.Round(triangle.GetArea(), 2);
        
        Assert.Equal(area, expected);
    }

    [Theory]
    [InlineData(2, 6, 7, false)]
    [InlineData(9, 40, 41, true)]
    [InlineData(12, 4.1, 9.4, false)]
    [InlineData(3, 4, 5, true)]
    public void Triangle_IsRight_ReturnsTrue_WhenTriangleIsRight(double a, double b, double c, bool expected)
    {
        var triangle = new Triangle(a, b, c);

        var isRight = triangle.IsRight;
        
        Assert.Equal(isRight, expected);
    }
}