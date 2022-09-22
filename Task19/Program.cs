// Задача 19 Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 99999 && number > 9999)
{
    if (GetFourDigitNumber(number) % 11 == 0)
        Console.Write($"Да - число {number} является палиндромом");
    else
        Console.Write($"Нет - число {number} не является палиндромом");
}
else
    Console.Write("Введите корректное число ");

int GetFourDigitNumber(int num)
{
    int firstTwoDigits = num / 1000;
    int secondTwoDigits = num % 100;
    return firstTwoDigits * 100 + secondTwoDigits;
}


// Console.Write("Введите пятизначное число ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number < 99999 && number > 9999)
// {
//     int firstPairOfDigits = number / 1000;
//     if (firstPairOfDigits == ReverseLastPairOfDigits(number))
//         Console.Write($"Да - число {number} является палиндромом");
//     else
//         Console.Write($"Нет - число {number} не является палиндромом");
// }
// else
//     Console.Write("Введите корректное число ");

// int ReverseLastPairOfDigits(int num)
// {
//     int lastPair = num % 100;
//     int lastDigit = lastPair % 10;
//     int penultimateDigit = lastPair / 10;
//     return lastDigit * 10 + penultimateDigit;
// }
