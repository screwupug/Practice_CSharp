//================================================================
// Метод подсчета
//================================================================

int[] ArrayGenerator()
{
    Random rnd = new Random();
    int[] array = new int[100];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 100);
    }
    return array;
}

// сортировка подсчётом
int[] CountingSort(int[] arr, int min, int max)
{
    int[] count = new int[max - min + 1];
    int z = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        count[arr[i] - min]++;
    }
    for (int i = min; i <= max; i++)
    {
        while (count[i - min]-- > 0)
        {
            arr[z] = i;
            z++;
        }
    }
    return arr;
}

void PrintArray(int[] array)
{
    Console.Write($"[{array[0]}, ");
    for(int i = 1; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]}]");
}

int[] array = new int[] {10, 7, 6, 3, 5, 1, 88};
int min = 1;
int max = 88;
int[] sortedArray = CountingSort(array, min, max);
PrintArray(array);
