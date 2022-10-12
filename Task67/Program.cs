// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int summ = SumOfDigits(number);
Console.WriteLine($"Сумма цифр числа = {summ}");

int SumOfDigits(int num)
{
    int sum = num % 10;
    if (num > 0) sum += SumOfDigits(num / 10);
    return sum;
}
