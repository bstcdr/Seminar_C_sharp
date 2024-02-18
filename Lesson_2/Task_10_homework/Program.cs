// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

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

if(num > 99 && num < 1000)
{
    int secondDigit = (num / 10) % 10;
    Console.WriteLine($"Вторая цифра -> {secondDigit}");
}
else
{
    Console.WriteLine("Введите трехзначное число!!!");
}