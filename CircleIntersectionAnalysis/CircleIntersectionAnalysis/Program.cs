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
        List<Circle> circles = new List<Circle>
        {
            new Circle(0, 0, 3),
            new Circle(4, 0, 2),
            new Circle(2, 2, 1),
            new Circle(10, 10, 2)
        };

        bool hasThreeIntersecting = false;
        for (int i = 0; i < circles.Count; i++)
        {
            for (int j = i + 1; j < circles.Count; j++)
            {
                for (int k = j + 1; k < circles.Count; k++)
                {
                    if (circles[i].Intersects(circles[j]) &&
                        circles[j].Intersects(circles[k]) &&
                        circles[i].Intersects(circles[k]))
                    {
                        hasThreeIntersecting = true;
                        Console.WriteLine($"Uchta kesishuvchi aylana: ({i + 1}, {j + 1}, {k + 1})");
                        break;
                    }
                }
                if (hasThreeIntersecting) break;
            }
            if (hasThreeIntersecting) break;
        }

        Console.WriteLine(hasThreeIntersecting
            ? "Uchta kesishuvchi aylana bor."
            : "Uchta kesishuvchi aylana yo'q.");
    }
}
