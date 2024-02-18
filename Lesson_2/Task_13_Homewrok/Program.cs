using System;
// Задача 13:Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет. Не использовать string[]
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Write("Введите число: ");

bool isParsed = false;
int num = 0;
while (isParsed == false)
{
    isParsed = int.TryParse(Console.ReadLine(), out num);
    if(isParsed == false)
    {
        Console.WriteLine("Пиши числа!");
    }
}

if(num > 99)
{
    while(num > 999)
    {
        num = num / 10; 
    }
    int answer = num % 10;
    Console.WriteLine($"-> {answer}");
}
else
{
    Console.WriteLine("третьей цифры нет");
}
