// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());

int ShowsSecondDigit(int num)
{
    if (ThreeDigitNumber(num))
        return -1;
    else
        return (num / 10) % 10;
}

bool ThreeDigitNumber(int arg)
{
    return arg > 999 || arg < 100;
}

int result = ShowsSecondDigit(number);

if (result == -1)
    Console.Write("Введите трехзначное число ");
else
    Console.WriteLine($"Вторая цифра числа {number} -> {result}");
