// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите двухзначное и более число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 9)
{
    int res = GetSumDigits(number);
    Console.WriteLine($"Сумма цифр числа {number} = {res}");
}
else
    Console.WriteLine("Введено некорректное значение");

int GetSumDigits(int num)
{
    int sum = default;
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}
