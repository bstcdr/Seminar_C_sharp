// Напишите программу, которая выводит случайное число 
// из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8   12 ->2   85-> 8

Random random = new Random();

int randomNum = random.Next(10, 100);

int lastDigit = randomNum % 10;
int firstDigit = randomNum / 10;

if(lastDigit > firstDigit)
{
    Console.WriteLine(lastDigit);
}
else
{
    Console.WriteLine(firstDigit);
}

Console.WriteLine(randomNum);
Console.WriteLine(firstDigit);
Console.WriteLine(lastDigit);