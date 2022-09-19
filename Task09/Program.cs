// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8


int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    if (IsEqualDigits(firstDigit, secondDigit))
        return 0;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

bool IsEqualDigits(int num1, int num2)
{
    return num1 == num2;
}

int number = new Random().Next(10, 100);
int maxDigit = MaxDigit(number);

//string result = maxDigit > 0 ? maxDigit.ToString() : "Цифры равны";
if (maxDigit > 0)
    Console.WriteLine($"Наибольшая цифра числа {number} = {maxDigit}");
else
    Console.WriteLine($"В числе {number} цифры равны");
