//===============================
// Строчный калькулятор
//===============================

string[] ReadData(string line)
{
    Console.Write(line);
    string inputLine = Console.ReadLine() ?? " ";
    string[] array = inputLine.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    return array;
}

char[] ParseOperators(string[] array)
{
    char[] operators = new char[2];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        switch (array[i])
        {
            case "+":
                {
                    operators[index] = char.Parse(array[i]);
                    index++;
                    break;
                }
            case "-":
                {
                    operators[index] = char.Parse(array[i]);
                    index++;
                    break;
                }
            case "*":
                {
                    operators[index] = char.Parse(array[i]);
                    index++;
                    break;
                }
            case "/":
                {
                    operators[index] = char.Parse(array[i]);
                    index++;
                    break;
                }
        }
    }
    return operators;
}

int[] ParseNumbers(string[] inputLine)
{
    string numbers = String.Empty;

    for (int i = 0; i < inputLine.Length; i++)
    {
        if (inputLine[i] != "+" && inputLine[i] != "-" && inputLine[i] != "*" && inputLine[i] != "/")
        {
            numbers += inputLine[i] + " ";
        }
    }
    string[] array = numbers.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    int[] numsArray = new int[array.Length];

    for (int i = 0; i < numsArray.Length; i++)
    {
        numsArray[i] = int.Parse(array[i]);
    }

    return numsArray;
}

bool Test(char[] operators)
{
    bool hasDivOrMult = false;
    for (int i = 0; i < operators.Length; i++)
    {
        if (operators[i] == '*' || operators[i] == '/')
        {
            hasDivOrMult = true;
        }
        else
        {
            hasDivOrMult = false;
        }
    }
    return hasDivOrMult;
}

int MathOperation(char[] operators, int[] numsArray, bool test)
{
    int res = 0;

    for (int i = 0; i < operators.Length; i++)
    {
        switch(i)
        {
            case 0:
            {
                if(operators[i] == '*' || operators[i] == '/')
                {
                    switch(operators[i])
                    {
                        case '*':
                        {
                            res = numsArray[0] * numsArray[1];
                            break;
                        }
                        case '/':
                        {
                            res = numsArray[0] / numsArray[1];
                            break;
                        }
                    }
                }
                else if(operators[i] == '+' || operators[i] == '-')
                {
                    if(test)
                    {
                        switch(operators[i])
                        {
                            case '+':
                            {
                                if(operators[1] == '*')
                                {
                                    res = numsArray[1] * numsArray[2] + numsArray[0];
                                }
                                else if(operators[1] == '/')
                                {
                                    res = numsArray[1] / numsArray[2] + numsArray[0];
                                }
                                break;
                            }
                            case '-':
                            {
                                if(operators[1] == '*')
                                {
                                    res = numsArray[1] * numsArray[2] - numsArray[0];
                                }
                                else if(operators[1] == '/')
                                {
                                    res = numsArray[1] / numsArray[2] - numsArray[0];
                                }
                                break;
                            }
                        }
                    }
                    else
                    {
                        switch(operators[i])
                        {
                            case '+':
                            {
                                res = numsArray[0] + numsArray[1];
                                break;
                            }
                            case '-':
                            {
                                res = numsArray[0] - numsArray[1];
                                break;
                            }
                        }
                    }
                }
                break;
            }
            case 1:
            {
                if(operators[1] == '+' || operators[1] == '-')
                {
                    switch(operators[1])
                    {
                        case '+':
                        {
                            res += numsArray[2];
                            break;
                        }
                        case '-':
                        {
                            res -= numsArray[2];
                            break;
                        }
                    }
                }
                break;
            }
        } 
    }

    return res;
}

string[] inputLine = ReadData("Введите пример с 2 мат знаками и 3 числами через пробел: ");
char[] operators = ParseOperators(inputLine);
int[] numbers = ParseNumbers(inputLine);
bool test = Test(operators);
int res = MathOperation(operators, numbers, test);

Console.WriteLine("Inputline:");
for (int i = 0; i < inputLine.Length; i++)
{
    Console.Write($"{inputLine[i]} ");
}

Console.WriteLine();

Console.WriteLine("Operators:");
for (int i = 0; i < operators.Length; i++)
{
    Console.WriteLine("" + operators[i]);
}

Console.WriteLine();

Console.WriteLine("Numbers:");
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"{numbers[i]} ");
}

Console.WriteLine();
Console.WriteLine($"Результат: {res}");
