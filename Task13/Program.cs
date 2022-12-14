// Задача 13: Напишите программу, которая выводит третью цифру заданного
// числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите любое число ");
long number = Convert.ToInt64(Console.ReadLine());

long GetThreeDigitNumber(long arg)
{
    while (arg > 999 || arg < -999)
    {
        arg = arg / 10;
    }
    return arg;
}

int ThirdDigit(int num)
{
    int thirdDigit = num % 10;
    return thirdDigit;
}

if (number > 99 || number < -99)
{
    long result = GetThreeDigitNumber(number);
    int res = ThirdDigit(Convert.ToInt32(result));
    Console.WriteLine($"Третья цифра числа {number} -> {res}");
}
else
    Console.Write($"У числа {number} третьей цифры нет");
