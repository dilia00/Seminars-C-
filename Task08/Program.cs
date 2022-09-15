// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine()); 
int current = 1;
while (current <= number) 
{
    if (current % 2 == 0)
    {
        Console.Write($"{current}, ");
    }
    current++;
}