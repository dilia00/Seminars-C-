// 12. Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если число 2 не кратно числу 1,
// то программа выводит остаток от деления. 34, 5 -> не кратно, остаток 4 16, 4 -> кратно


Console.Write("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());
bool IsAliquot(int arg1, int arg2)
{
    return arg1 % arg2 == 0;
}

if (IsAliquot(number1, number2))
    Console.Write($"{number1} кратно {number2}");
else
    Console.Write($"{number1} не кратно {number2} остаток от деления равен {number1 % number2}");
