//===============================
// Генератор чисел Фибоначи
// Fn = F(n-1) + F(n-2)
//===============================

int[,] array2D = new int[5, 5];
int startCol = 0;
int endCol = array2D.GetLength(1) - 1;
int startRow = 0;
int endRow = array2D.GetLength(0) - 1;
int counter = 1;

while (startCol <= endCol && startRow <= endRow)
{
    for (int i = startCol; i <= endCol; i++)
    {
        array2D[startRow, i] = counter;
        counter++;
    }
    startRow++;

    for (int j = startRow; j <= endRow; j++)
    {
        array2D[j, endCol] = counter;
        counter++;
    }
    endCol--;

    for (int k = endCol; k >= startCol; k--)
    {
        array2D[endRow, k] = counter;
        counter++;
    }
    endRow--;

    for (int n = endRow; n >= startRow; n--)
    {
        array2D[n, startCol] = counter;
        counter++;
    }
    startCol++;
}

for (int i = 0; i < array2D.GetLength(0); i++)
{
    for (int j = 0; j < array2D.GetLength(1); j++)
    {


        Console.Write($"{array2D[i, j]} ");

    }
    Console.WriteLine();
}