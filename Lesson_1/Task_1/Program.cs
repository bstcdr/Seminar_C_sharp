// 1. Напишите программу, которая на вход принимает 
// число и выдает ее квадрат (число умноженное на само себя),
// Например: 4->16, -3->9, 7->49

int number = int.Parse(Console.ReadLine());

int result = number * number;

Console.Write("Квадрат заданного числа = ");
Console.WriteLine(result);