// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число m: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int res = AckermannFunction(numberM, numberN);
Console.WriteLine($"Результат функции Аккермана чисел {numberM}(m) и {numberN}(n) = {res}");

int AckermannFunction(int numM, int numN)
{
    if (numM == 0) return numN + 1;
    else if (numM > 0 && numN == 0) return AckermannFunction(numM - 1, 1);
    return AckermannFunction(numM - 1, AckermannFunction(numM, numN - 1));
}