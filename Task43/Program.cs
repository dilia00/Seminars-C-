// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите параметры первой прямой");
Console.Write("К1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("В1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите параметры второй прямой");
Console.Write("К2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("В2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

double FindX(double argK1, double argB1, double argK2, double argB2)
{
    //argK1*x + argB1 == argK2*x + argB2
    //argK1*x + (- argK2*x) == (-argB1) + argB2
    //(argK1 +(- argK2))* x == (-argB1)+argB2
    return ((-argB1) + argB2) / (argK1 + (-argK2));
}

double FindY(double argK1, double argB1)
{
    return argK1 * FindX(k1, b1, k2, b2) + argB1;
}

double x = FindX(k1, b1, k2, b2);
double y = FindY(k1, b1);
if (y == k2 * x + b2)
    Console.WriteLine($"Прямые пересекаются в точке ({Math.Round(x, 1)}; {Math.Round(y, 1)})");
else
    Console.WriteLine("Прямые не пересекаются");