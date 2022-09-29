// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random(); // var или Random тип данных с левой стороны

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]}, ");
        else
            Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

bool CheckNumber(int[] array, int arg)
{
    bool checkNum = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == arg)
        {
            checkNum = true;
            break;
        }
    }
    return checkNum;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);
bool checkNumber = CheckNumber(arr, number);
if (checkNumber)
    Console.WriteLine("Да - в массиве присутствует данное число");
else
    Console.WriteLine("Нет - в массиве отсутствует данное число");
