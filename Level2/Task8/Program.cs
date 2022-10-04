//================================================================
// Вознаграждение мп
//================================================================

double ReadData(string line)
{
    Console.Write(line);
    double number = double.Parse(Console.ReadLine() ?? "0");
    return number;
}

double CalculateFee(double number)
{
    double result = number * 0.25;
    return result;
}

double CalculateSum(double number)
{
    double result = number - (number * 0.25);
    return result;
}

void PrintData(string line)
{
    Console.WriteLine(line);
}

double inputNumber = ReadData("Введите стоимость товара: ");
double res1 = CalculateFee(inputNumber);
double res2 = CalculateSum(inputNumber);
PrintData($"Размер комиссий 25%, мп заберет - {res1} руб., вы получите - {res2} руб.");
