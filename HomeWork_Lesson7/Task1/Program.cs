// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5  7    -2   -0,2
// 1   -3,3   8   -9,9
// 8    7,8  -7,1  9


const int m = 3;
const int n = 4;
const int minNumber = -10;
const int maxNumber = 10;

double[,] array = new double[m, n];

void FillArray()
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.NextDouble() * (maxNumber - minNumber) + minNumber;
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
            Console.Write($"{array[i, j]:F1} \t");
        }
    }
    Console.WriteLine();
}

FillArray();
PrintArray();