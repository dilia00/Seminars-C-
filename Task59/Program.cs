// // Задача 59: Задайте двумерный массив из целых чисел.
// // Напишите программу, которая удалит строку и столбец, на
// // пересечении которых расположен наименьший элемент
// // массива.

int[,] myMatrix = CreateMatrix(4, 4, 1, 9);
PrintMatrix(myMatrix);
Console.WriteLine();
int[] findMinNumber = FindMinNumber(myMatrix);
PrintArray(findMinNumber);
Console.WriteLine();
int[,] newMyMatrix = RemoveRowColumnMinElement(myMatrix, findMinNumber);
PrintMatrix(newMyMatrix);


int[,] RemoveRowColumnMinElement(int[,] matrix, int[] array)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int i = 0;
    int j = 0;
    for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
            if (m != array[0] && n != array[1])
            {
                newMatrix[i, j] = matrix[m, n];
                j = j + 1;
            }
        }
        j = 0;
        if (m != array[0])
            i = i + 1;
    }
    return newMatrix;
}

int[] FindMinNumber(int[,] matrix)
{
    int min = matrix[0, 0];
    int indexMinI = 0;
    int indexMinJ = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                indexMinI = i;
                indexMinJ = j;
            }
            else if (matrix[i, j] == min)
            {
                indexMinI = i;
                indexMinJ = j;
            }
        }
    }
    return new int[] { indexMinI, indexMinJ, min };
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




