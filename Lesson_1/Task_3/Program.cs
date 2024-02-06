// Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 2 -> " -2, -1, 0, 1, 2"

int number = int.Parse(Console.ReadLine());

if (number > 0)
{
    for (int i = -number; i <= number; i++)
    {
        Console.Write(i);
        Console.Write(", ");
    } 
}
else
{
    for (int i = number; i <= -number; i++)
    {
        Console.Write(i);
        Console.Write(", ");
    } 
}
