// 11.Напишите программу, которая выводит случайное 
// трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46 782 -> 72 918 -> 98

Random random = new Random();

int randomNum = random.Next(100, 1000);

int firstDigit = randomNum / 100;
int lastDigit = randomNum % 10;

int result = (firstDigit * 10) + lastDigit;
Console.WriteLine(randomNum);
Console.WriteLine(result);