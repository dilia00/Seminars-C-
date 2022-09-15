// 7. Напишите программу, которая принимает на вход трехзначное число
//  и на выходе показывает последнюю цифру этого числа.
// 456 -> 6


Console.Write("Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine()); 
if (number > 99 && number < 1000) 
{
    int resalt = number % 10;
    Console.WriteLine(resalt);
}
else
{
    Console.Write("Введите правильное число ");
}