// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет

Console.Write("Введите ряд элемента: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец элемента: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateMatrix(3, 4, -10, 10);
PrintMatrix(myArray);
FindElement(myArray, row, column);

void FindElement(int[,] matrix, int rows, int columns)
{
    if (matrix.GetLength(0) >= rows && matrix.GetLength(1) >= columns)
        Console.WriteLine($"Элемент найден: {matrix[rows - 1, columns - 1]}");
    else Console.WriteLine($"Tакого элемента в массиве нет");
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
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("|");
    }
}
