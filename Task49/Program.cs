// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

// int[,] myMatrix = CreateMatrix(3, 4, 1, 9);
// PrintMatrix(myMatrix);
// Console.WriteLine();
// ChangeEvenIndexOfElement(myMatrix);
// PrintMatrix(myMatrix);

// void ChangeEvenIndexOfElement(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0) matrix[i, j] *= matrix[i, j];
//         }
//     }
// }

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



int[,] array2D = CreateMatrix(3, 4, 1, 10);
PrintMatrix(array2D);
System.Console.WriteLine();

GetSquareEvenElem(array2D);
PrintMatrix(array2D);

// метод возведение чётных элементов массива в квадрат
void GetSquareEvenElem(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i += 2)  //rows (0)
    {
        for (int j = 0; j < matrix.GetLength(1); j += 2) //columns (1)
        {
            matrix[i, j] *= matrix[i, j];
        }
    }
}
