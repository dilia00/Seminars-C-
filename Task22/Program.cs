// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

void SquareTable(int arg)
{
    int counter = 1;
    while (counter <= arg)
    {
        Console.WriteLine($"|{counter, 3} | {counter * counter, 5}|");
        counter++;
    }
}
if (number > 0)
    SquareTable(number);
else
    Console.Write("Введите корректное число ");
