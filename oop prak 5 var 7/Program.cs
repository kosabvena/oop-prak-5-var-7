using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        TCircle<Real> circle1 = new TCircle<Real>();
        circle1.Input();

        TCircle<Real> circle2 = new TCircle<Real>(new Real(5));

        TCircle<Real> circle3 = new TCircle<Real>(circle2);

        Console.WriteLine("\nКоло 1:");
        circle1.Output();

        Console.WriteLine("\nКоло 2:");
        circle2.Output();

        Console.WriteLine("\nКоло 3:");
        circle3.Output();

        Console.Write("\nВведіть кут сектора: ");
        double angle = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Площа сектора: " + circle2.SectorArea(angle));

        Console.WriteLine("\nПорівняння:");

        if (circle1 > circle2)
            Console.WriteLine("Коло 1 більше за коло 2");

        if (circle1 < circle2)
            Console.WriteLine("Коло 1 менше за коло 2");

        if (circle1 == circle2)
            Console.WriteLine("Кола однакові");

        TCircle<Real> sum = circle1 + circle2;
        Console.WriteLine("\nСума радіусів: " + sum.radius);

        TCircle<Real> difference = circle1 - circle2;
        Console.WriteLine("Різниця радіусів: " + difference.radius);

        Console.Write("\nВведіть число, на яке потрібно помножити радіус: ");
        Real number = new Real(Convert.ToDouble(Console.ReadLine()));

        TCircle<Real> multiply = circle2 * number;
        Console.WriteLine("Радіус після множення: " + multiply.radius);

        Console.WriteLine("\n=== Те саме для цілого радіуса ===");
        TCircle<Integer> ci1 = new TCircle<Integer>(new Integer(3));
        TCircle<Integer> ci2 = new TCircle<Integer>(new Integer(4));

        ci1.Output();
        Console.WriteLine("Сума радіусів: " + (ci1 + ci2).radius);
        Console.WriteLine("Різниця радіусів: " + (ci2 - ci1).radius);
        Console.WriteLine("Множення на 2: " + (ci1 * new Integer(2)).radius);
    }
}