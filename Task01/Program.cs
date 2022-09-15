
Console.Write("Введите первое число ");
int square = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int number = Convert.ToInt32(Console.ReadLine());
if (square == number*number)
{
    Console.WriteLine($"Число {square} является квадратом числа {number}");
}
else
{
    Console.WriteLine($"Число {square} не является квадратом числа {number}");
}
