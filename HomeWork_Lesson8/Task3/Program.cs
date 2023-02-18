// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] firstMatrix = new int[,] { { 2, 4 }, { 3, 2 } };
int[,] secondMatrix = new int[,] { { 3, 4 }, { 3, 3 } };
int[,] resultMatrix = new int[2, 2];

PrintMatrix();
MultiplyMatrix();
Console.WriteLine($"Результирующая матрица будет:");
PrintArray(resultMatrix);


void MultiplyMatrix()
{
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < firstMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                sum += firstMatrix[i, k] * secondMatrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

void PrintArray(int[,] array)
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


void PrintMatrix()
{
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        if (i != 0) Console.WriteLine();
        for (int j = 0; j < firstMatrix.GetLength(1); j++)
        {
            Console.Write($"{firstMatrix[i, j]} ");
        }
        Console.Write($"| ");
        for (int k = 0; k < secondMatrix.GetLength(1); k++)
        {
            Console.Write($"{secondMatrix[i, k]} ");
        }
    }
    Console.WriteLine();
}
