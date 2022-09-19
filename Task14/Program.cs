// 14. Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23. 14 -> нет 46 -> нет 161 -> да


Console.Write("Введите число ");
int number1 = Convert.ToInt32(Console.ReadLine());

bool IsEqualDigits(int arg1, int arg2, int arg3)
{
    return arg1 % arg2 == 0 && arg1 % arg3 == 0;
}
bool result = IsEqualDigits(number1, 7, 23);

if (result)
    Console.Write($"Да - {number1} кратно 7 и 23");
else
    Console.Write($"Нет - {number1} не кратно 7 и 23");
