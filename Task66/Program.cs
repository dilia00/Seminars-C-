// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int mySum = default;
if (numberM < numberN)
    mySum = NaturalNumInSum(numberM, numberN);
else
    mySum = NaturalNumInSum(numberN, numberM);
Console.WriteLine($"Сумма натуральных элементов в промежутке от {numberM} до {numberN} = {mySum}");

int NaturalNumInSum(int num1, int num2)
{
    if (num1 > num2) return 0;
    return num2 += NaturalNumInSum(num1, num2 - 1);
}