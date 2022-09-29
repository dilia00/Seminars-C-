// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndInt(int size, int min, int max)
{
    double[] array = new double[size];
    var rnd = new Random(); // var или Random тип данных с левой стороны

    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round((rnd.NextDouble() * (max - min) + min), 1);
    }
    return array;
}

void PrintArray(double[] array)
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

int GetIndexMaxElement(double[] array)
{
    int indexMaxElement = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > array[indexMaxElement])
            indexMaxElement = i;
    }
    return indexMaxElement;
}

int GetIndexMinElement(double[] array)
{
    int indexMinElement = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < array[indexMinElement])
            indexMinElement = i;
    }
    return indexMinElement;
}

double DifferenceMaxMinElements(double[] array)
{
    double maxElement = array[GetIndexMaxElement(array)];
    double minElement = array[GetIndexMinElement(array)];
    return maxElement - minElement;
}

double[] arr = CreateArrayRndInt(5, 0, 99);
PrintArray(arr);
double result = Math.Round(DifferenceMaxMinElements(arr), 1);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {result}");
