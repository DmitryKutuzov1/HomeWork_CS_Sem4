// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void PrintArray(int[] array, int sep)
{
    int length = array.Length;
    Console.Write("[");
    for (int i = 0; i < sep - 1; i++)
        Console.Write($"{array[i]}" + ", ");
    Console.Write(array[sep - 1] + "]");
    Console.WriteLine();
    Console.Write("[");
    for (int i = sep; i < length - 1; i++)
        Console.Write($"{array[i]}" + ", ");
    Console.Write(array[length - 1] + "]");
    Console.WriteLine();
}

void FillArray(int[] collection)
{
    int length = collection.Length;
    for (int i = 0; i < length; i++)
        collection[i] = new Random().Next(0, 100);
}

int[] array = new int[8];
int a = 5;     //Переменная для определения колличества элементов массива, показанных в первой строчке
FillArray(array);
Console.WriteLine($"[{String.Join(", ", array)}]");    //Вывод массива целиком
PrintArray(array, a);