int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

string ReadMathOperator(string line)
{
    Console.Write(line);
    string mathOperator = Console.ReadLine() ?? "null";
    return mathOperator;
}

double CalculateData(double a, double b, string c)
{
    string mathOperator = c;
    double result = 0;

    switch (mathOperator)
    {
        case "+":
            result = a + b;
            break;
        case "-":
            result = a - b;
            break;
        case "*":
            result = a * b;
            break;
        case "/":
            result = a / b;
            break;
        default:
            result = 0;
            break;    
    }
    return result;
}

void Printdata(string line)
{
    Console.WriteLine(line);
}

int a = ReadData("Введите число 1: ");
string mathOperator = ReadMathOperator("Введите мат. знак: ");
int b = ReadData("Введите число 2: ");
double result = CalculateData(a, b, mathOperator);
Printdata($"Результат: {result}");
