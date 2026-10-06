using System;

class TCircle<T> where T : struct, IComparable<T>, IArithmetic<T>
{
    public T radius;

    public TCircle()
    {
        radius = default(T);
    }

    public TCircle(T r)
    {
        radius = r;
    }

    public TCircle(TCircle<T> circle)
    {
        radius = circle.radius;
    }

    public void Input()
    {
        Console.Write("Введіть радіус: ");
        radius = default(T).Parse(Console.ReadLine());
    }

    public void Output()
    {
        Console.WriteLine("Радіус: " + radius);
        Console.WriteLine("Площа круга: " + Area());
        Console.WriteLine("Довжина кола: " + Length());
    }

    public double Area()
    {
        return Math.PI * radius.ToDouble() * radius.ToDouble();
    }

    public double SectorArea(double angle)
    {
        return Math.PI * radius.ToDouble() * radius.ToDouble() * angle / 360;
    }

    public double Length()
    {
        return 2 * Math.PI * radius.ToDouble();
    }

    public static bool operator >(TCircle<T> a, TCircle<T> b)
    {
        return a.radius.CompareTo(b.radius) > 0;
    }

    public static bool operator <(TCircle<T> a, TCircle<T> b)
    {
        return a.radius.CompareTo(b.radius) < 0;
    }

    public static bool operator ==(TCircle<T> a, TCircle<T> b)
    {
        return a.radius.CompareTo(b.radius) == 0;
    }

    public static bool operator !=(TCircle<T> a, TCircle<T> b)
    {
        return a.radius.CompareTo(b.radius) != 0;
    }

    public override bool Equals(object obj)
    {
        return obj is TCircle<T> c && radius.CompareTo(c.radius) == 0;
    }

    public override int GetHashCode()
    {
        return radius.GetHashCode();
    }

    public static TCircle<T> operator +(TCircle<T> a, TCircle<T> b)
    {
        return new TCircle<T>(default(T).Add(a.radius, b.radius));
    }

    public static TCircle<T> operator -(TCircle<T> a, TCircle<T> b)
    {
        return new TCircle<T>(default(T).Subtract(a.radius, b.radius));
    }

    public static TCircle<T> operator *(TCircle<T> a, T number)
    {
        return new TCircle<T>(default(T).Multiply(a.radius, number));
    }
}