// Задача 23
// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

void СubeTable(int arg)
{
    int counter = 1;
    while (counter <= arg)
    {
        //Console.WriteLine($"|{counter, 3} | {Math.Pow(counter, 3), 5}|");
        Console.WriteLine($"|{counter, 3} | {counter * counter * counter, 5}|");
        counter++;
    }
}
if (number > 0)
    СubeTable(number);
else
    Console.Write("Введите корректное число ");
