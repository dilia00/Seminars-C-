// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


Console.Write("Введите какое количестао чисел вы хотите ввести: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[size];
for (int i = 0; i < size; i++)
{
    Console.Write($"Введите {i + 1}-e число из {size}: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
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

int GetNumberOfPositiveNumbers(int[] array)
{
    int count = default;
    for (int i = 0; i < arr.Length; i++)
    {
        if (array[i] > 0)
            count++;
    }
    return count;
}
Console.WriteLine();
PrintArray(arr);
Console.WriteLine($"Количество положительных чисел = {GetNumberOfPositiveNumbers(arr)}");