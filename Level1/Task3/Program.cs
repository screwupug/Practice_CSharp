//================================================================
// Задача 3 Составить программу вывода на экран числа, вводимого с клавиатуры. 
// Выводимому числу должно предшествовать сообщение «Вы ввели число».
//================================================================

string? inputLine = Console.ReadLine();
if(inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    Console.WriteLine("Вы ввели число: " + inputNumber);
}
