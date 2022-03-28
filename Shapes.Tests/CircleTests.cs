using System;
using Xunit;

namespace Shapes.Tests;

public class CircleTests
{
    [Theory]
    [InlineData(100, 31415.927)]
    [InlineData(10, 314.159)]
    [InlineData(2.5, 19.635)]
    [InlineData(1.4, 6.158)]
    public void GetArea_Returns_RightValue(double radius, double expected)
    {
        var circle = new Circle(radius);
        
        var roundedArea = Math.Round(circle.GetArea(), 3);
        
        Assert.Equal(roundedArea, expected);
    }
}