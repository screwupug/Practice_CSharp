//================================================================
// Задача 3 Дан радиус окружности. Найти ее диаметр. 
//================================================================
Console.Write("Введите радиус окружности: ");
string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    double radius = double.Parse(inputLine);

    if(radius > 0)
    {
        double diametr = radius * 2;
        // Console.WriteLine($"Диаметр окружности равен: {diametr}");
        Console.WriteLine("Диаметр окружности = {0}", diametr); // Еще один способ записи переменных
    }
    else
    {
        Console.WriteLine("Неправильный ввод");
    }
}
