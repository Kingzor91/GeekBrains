// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

const int m = 3;
const int n = 4;

int[,] array = new int[m, n];

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
            Console.Write($"{array[i, j]}\t");
        }
    }
    Console.WriteLine();
}

void FindAvgArray()
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double avg = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            avg = avg + array[i,j];
        }
        avg = avg / n;
        Console.Write($"{avg};\t");
    }
    Console.WriteLine();
}

FillArray();
PrintArray();
FindAvgArray();