// Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 2 -> " -2, -1, 0, 1, 2"

int number = int.Parse(Console.ReadLine());

int i = 0;
int result = 0;
for (i = 0; i < ((number * 2) + 1); i++)
{
    result = (number * (-1)) + i;
    Console.WriteLine(result);
} 

