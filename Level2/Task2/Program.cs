//================================================================
// Задача 2 Дана сторона квадрата. Найти его периметр
//================================================================

Console.Write("Введите значение стороны квадрата: ");
string? inputLine = Console.ReadLine();

if(inputLine != null)
{
    double squareSide = double.Parse(inputLine);

    if(squareSide > 0)
    {
        double perimeter = squareSide * 4;
        Console.WriteLine($"Периметр квадрата: {perimeter}");
    }
    else 
    {
        Console.WriteLine("Error");
    }
}
