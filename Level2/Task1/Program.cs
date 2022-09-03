//================================================================
// Задача 1 Составить программу:
// а) вычисления значения функции y=7x2+3x+6 при любом значении x;
// б) вычисления значения функции x=12a2+7a+12 при любом значении а.
//================================================================

Random rdn = new Random();
double x1 = rdn.Next(1, 20);
Console.WriteLine($"{x1}");
double y = 7 * Math.Pow(x1, 2) + 3 * x1 + 6;
Console.WriteLine(y);

double a =rdn.Next(1, 20);
Console.WriteLine($"{a}");
double x = 12 * Math.Pow(a, 2) + 7 * a + 12;
Console.WriteLine(x);
