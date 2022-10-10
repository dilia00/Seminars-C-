// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] myMatrix = CreateMatrix(4, 3, 1, 9);
PrintMatrix(myMatrix);
Console.WriteLine();
int[] getSumRowsArray = GetSumRowsArray(myMatrix);
PrintArray(getSumRowsArray);
int getIndexMinElement = GetIndexMinlement(getSumRowsArray);
Console.WriteLine($"Наименьшая сумма элементов в строке: {getIndexMinElement + 1}-я сторока");

int GetIndexMinlement(int[] array)
{
    int indexMinElement = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < array[indexMinElement])
            indexMinElement = i;
    }
    return indexMinElement;
}

int[] GetSumRowsArray(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    int sum = default;
    for (int i = 0; i < matrix.GetLength(0); i++)  //rows (0)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //columns (1)
        {
            sum = sum + matrix[i, j];
        }
        array[i] = sum;
        sum = 0;
    }
    return array;
}

int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)  //rows (0)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //columns (1)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i],4}, ");
        else
            Console.Write($"{array[i],4}");
    }
    Console.WriteLine("]");
}



