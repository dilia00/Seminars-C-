// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


Console.Write("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 < number2)
{
    NaturalNumInRange(number1, number2);
}
else
{
    NaturalNumInRange(number2, number1);
}

void NaturalNumInRange(int num1, int num2)
{
    if (num1 > num2) return;
    NaturalNumInRange(num1, num2 - 1);
    Console.Write($"{num2} ");
}


Console.WriteLine();
Console.WriteLine("Введите первое число");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberN = Convert.ToInt32(Console.ReadLine());
NaturalNumbersFromMToN(numberM, numberN);

void NaturalNumbersFromMToN(int numM, int numN)
{
    if (numM < numN)
    {
        Console.Write($"{numM} "); // 1 2 3 4
        NaturalNumbersFromMToN(numM + 1, numN); // 2, 5 | 3, 5| 4,5 | 5, 5
    }
    if (numM > numN)
    {
        Console.Write($"{numM} ");
        NaturalNumbersFromMToN(numM - 1, numN);
    }
    if (numN == numM) Console.Write($"{numM} "); // 5
}
