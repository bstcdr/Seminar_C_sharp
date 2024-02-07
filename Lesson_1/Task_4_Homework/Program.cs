// Задача 4: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите 1-ое число: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Введите 2-ое число: ");
int num2 = int.Parse(Console.ReadLine());

Console.Write("Введите 3-е число: ");
int num3 = int.Parse(Console.ReadLine());

if (num1 > num2 && num1 > num3)
{
    int max = num1;
    Console.WriteLine($"max = {max}");
}
else if (num2 > num1 && num2 > num3)
{
    int max = num2;
    Console.WriteLine($"max = {max}");
}
else if (num3 > num1 && num3 > num2)
{
    int max = num3;
    Console.WriteLine($"max = {max}");
}
else
{
    Console.WriteLine($"они равны");
}