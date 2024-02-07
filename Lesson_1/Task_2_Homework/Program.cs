using System.Diagnostics.Tracing;
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите 1-ое число: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Введите 2-ое число: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    int max = num1;
    Console.WriteLine($"max = {max}");
}
else if (num2 > num1)
{
    int max = num2;
    Console.WriteLine($"max = {max}");
}
else
{
    Console.WriteLine("Они равны");
}