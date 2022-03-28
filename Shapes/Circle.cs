namespace Shapes;

public class Circle : Shape
{
    private double _radius;

    public double Radius
    {
        get => _radius;
        set
        {
            CheckSide(value);
            _radius = value;
        }
    }
    
    public Circle() { }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetArea() =>
        Math.PI * Math.Pow(Radius, 2);
}