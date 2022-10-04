// ===================================================================
// Задача 7 Отсортировать массив от меньшего к большему 
// 6 8 3 2 1 4 5 7
// ===================================================================

void CalculateData(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] > array[maxPosition])
            {
                maxPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

void Printdata(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int[] array = {6, 8, 3, 2, 1, 4, 5, 7};
CalculateData(array);
Printdata(array);
