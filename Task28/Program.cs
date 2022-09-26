// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int GetFact(int num)
// {
//     int counter = 1;
//     int res = 1;
//     while (counter <= num)
//     {
//         res = res * counter;
//         counter++;
//     }
//     return res;
// }
// int result = GetFact(Math.Abs(number));
// Console.WriteLine(result);


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    int result = DigitMultiplication(number);
    Console.WriteLine($"Произведение чисел от 1 до {number} = {result}");
}
else
    Console.WriteLine("Введено некорректное значение");

int DigitMultiplication(int num)
{
    int multiplic = 1;
    for (int i = 1; i <= num; i++)
    {
        multiplic = multiplic * i;
    }
    return multiplic;
}
