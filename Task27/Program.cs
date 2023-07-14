// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDigits (int n)
{
    int sum = 0;
    for (int i = n; i > 0; i /= 10)
        sum = sum + i % 10;
    return sum;
}

int GetImput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetImput("Введите число: ");
Console.WriteLine($"Сумма цифр числа {number} равна {SumDigits(number)}");