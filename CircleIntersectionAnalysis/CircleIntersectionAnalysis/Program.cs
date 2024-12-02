class Circle
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Radius { get; set; }

    public Circle(double x, double y, double radius)
    {
        X = x;
        Y = y;
        Radius = radius;
    }

    public bool Intersects(Circle other)
    {
        double distance = Math.Sqrt(Math.Pow(X - other.X, 2) + Math.Pow(Y - other.Y, 2));
        return distance <= Radius + other.Radius && distance >= Math.Abs(Radius - other.Radius);
    }
}

class Program
{
    static void Main()
    {
        
    }
}
