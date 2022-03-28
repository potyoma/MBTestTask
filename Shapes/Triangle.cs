namespace Shapes;

public class Triangle : Shape
{
    private double _sideA;
    private double _sideB;
    private double _sideC;

    public double SideA
    {
        get => _sideA;
        set
        {
            CheckSide(value);
            _sideA = value;
        }
    }

    public double SideB
    {
        get => _sideB;
        set
        {
            CheckSide(value);
            _sideB = value;
        }
    }

    public double SideC
    {
        get => _sideC;
        set
        {
            CheckSide(value);
            _sideC = value;
        }
    }

    public bool IsRight { get; private set; }
    private double[] Legs { get; set; }

    public Triangle()
    {
    }

    public Triangle(double side)
    {
        SideA = side;
        SideB = side;
        SideC = side;
        Check();
    }

    public Triangle(double side1, double side2)
    {
        SideA = side1;
        SideB = side1;
        SideC = side2;
        Check();
    }

    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
        Check();
    }

    private void Check()
    {
        if (!(SumIsMoreThanThird(_sideA, _sideB, _sideC)
              || SumIsMoreThanThird(_sideB, _sideC, _sideA)
              || SumIsMoreThanThird(_sideC, _sideA, _sideB)))
            throw new ArgumentException("The sum of two side lengths has to exceed the length of the third side.");

        IsRight = ArePythagorecallyEqual(_sideA, _sideB, _sideC)
                  || ArePythagorecallyEqual(_sideB, _sideA, _sideC)
                  || ArePythagorecallyEqual(_sideC, _sideA, _sideB);
    }

    private bool SumIsMoreThanThird(double sideA, double sideB, double sideC) =>
        sideA + sideB > sideC;

    private bool ArePythagorecallyEqual(double sideA, double sideB, double sideC) =>
        Math.Pow(sideA, 2) == Math.Pow(sideB, 2) + Math.Pow(sideC, 2)
            ? SetLegs(sideB, sideC)
            : false;

    private bool SetLegs(double sideB, double sideC)
    {
        Legs = new[] {sideB, sideC};
        return true;
    }

    public override double GetArea()
    {
        if (IsRight) return GetRightTriangleArea();

        double halfPerimeter = (_sideA + _sideB + _sideC) / 2;
        double area = Math.Sqrt(halfPerimeter * (halfPerimeter - _sideA) * (halfPerimeter - _sideB) *
                                (halfPerimeter - _sideC));
        return area;
    }

    private double GetRightTriangleArea() => Legs[0] * Legs[1] / 2;
}