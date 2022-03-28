namespace Shapes;

public interface IShape
{
    double GetArea();
}

public abstract class Shape : IShape
{
    protected void CheckSide(double value)
    {
        if (value < 0) throw new ArgumentException("Side can't be less than zero");
    }

    public virtual double GetArea() => 0;
}