// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetPower(int a, int b)
{
    int result = a;
    for (int i = 2; i <= b; i++)
        result *= a;
    return result;
}

int GetImput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int numberA = GetImput("Введите число: ");
int numberB = GetImput("Введите степень: ");
Console.WriteLine($"Число {numberA} в степени {numberB} равно {GetPower(numberA, numberB)}");