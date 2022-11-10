//2.2.  Оператор выбора вариантов. Плотников Кирилл Андреевич 22-ИСП-2/2
//№варианта:16, Даны значения трех сторон треугольника a, b, и c.Наименьшая  из  сторон  треугольника  является стороной квадрата. Определить, площадь какой из фигур больше.(1) a=3;  b=5;  c=4 (2).a=3;  b=8;  c=11 (3).a=9;  b=9;  c=9

try
{
    Console.ForegroundColor = ConsoleColor.Blue;

    double a1 = 3, b1 = 5, c1 = 4, a2 = 3, b2 = 8, c2 = 11, a3 = 9, b3 = 9, c3 = 9;

    double S1, P1, S2, P2, S3, P3;
    {
        P1 = (a1 + b1 + c1) / 2; //полупериметр треугольника№1
        S1 = Math.Sqrt(P1 * (P1 - a1) * (P1 - b1) * (P1 - c1));//S треугольника№1
        Console.WriteLine("Площадь треугольника№1 равен:");
        Console.WriteLine($"{S1:F2}");

        P2 = (a2 + b2 + c2) / 2; //полупериметр треугольника№2
        S2 = Math.Sqrt(P2 * (P2 - a2) * (P2 - b2) * (P2 - c2));//S треугольника№2
        Console.WriteLine("Площадь треугольника№2 равен:");
        Console.WriteLine($"{S2:F2}");

        P3 = (a3 + b3 + c3) / 2; //полупериметр треугольника№3
        S3 = Math.Sqrt(P3 * (P3 - a3) * (P3 - b3) * (P3 - c3));//S треугольника№3
        Console.WriteLine("Площадь треугольника№3 равен:");
        Console.WriteLine($"{S3:F2}");
    }
    Console.ForegroundColor = ConsoleColor.DarkBlue;

    double Sbox1, Sbox2, Sbox3;
    {
        Sbox1 = Math.Sqrt(Math.Pow(a1, 2)); //S квадрата№1
        Console.WriteLine("Площадь квадрата№1 равен:");
        Console.WriteLine($"{Sbox1:F2}");

        Sbox2 = Math.Sqrt(Math.Pow(a2, 2)); //S квадрата№2
        Console.WriteLine("Площадь квадрата№2 равен:");
        Console.WriteLine($"{Sbox2:F2}");

        Sbox3 = Math.Sqrt(Math.Pow(a3, 2)); //S квадрата№3
        Console.WriteLine("Площадь квадрата№3 равен:");
        Console.WriteLine($"{Sbox3:F2}");
    }

    Console.ForegroundColor = ConsoleColor.Green;

    if (S1 > Sbox1) Console.WriteLine("Площадь треугольника№1 больше площади квадрата№1.");
    else Console.WriteLine("Площадь квадрата№1 больше площади треугольника №1.");

    if (S2 > Sbox2) Console.WriteLine("Площадь треугольника№2 больше площади квадрата№2.");
    else Console.WriteLine("Площадь квадрата№2 больше площади треугольника №2.");

    if (S3 > Sbox3) Console.WriteLine("Площадь треугольника№3 больше площади квадрата№3.");
    else Console.WriteLine("Площадь квадрата№3 больше площади треугольника №3.");

    Console.ForegroundColor = ConsoleColor.White;
}
catch (Exception ex)
{ Console.WriteLine(ex.ToString()); }
