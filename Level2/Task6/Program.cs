int number = 3232134;
char[] charArray = number.ToString().ToCharArray();
Array.Reverse(charArray);
char[] reversedaArray = charArray;
Console.WriteLine(reversedaArray);
int b = int.Parse(reversedaArray);
Console.WriteLine(b);


if(b == number)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}
