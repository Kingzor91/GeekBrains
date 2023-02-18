// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

const int m = 4;
const int n = 4;

int[,] array = new int[m, n];

int min = int.MaxValue;
int index = 0;

FillArray();
PrintArray();
SearchRowMinElement();
System.Console.WriteLine($"Номер строки с наименьшей суммой элементов: {index} строка");

void SearchRowMinElement()
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int tmp = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            tmp += array[j, i];
        }
        if (tmp < min)
        {
            min = tmp;
            index = j + 1;
        }
    }
}

void FillArray()
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i != 0) Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
    }
    Console.WriteLine();
}