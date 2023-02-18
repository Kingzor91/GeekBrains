// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

const int m = 3;
const int n = 4;

int[,] massive = GenerateArray(m, n);
int[] temp = new int[massive.GetLength(1)];

PrintArray(massive);
Console.WriteLine("Сортированный массив");
for (int i = 0; i < massive.GetLength(0); i++)
{
    for (int j = 0; j < massive.GetLength(1); j++)
        temp[j] = massive[i, j];
    Sort(temp);
    Insert(temp, i);
}
PrintArray(massive);

void Sort(int[] arr)
{
    for (int i = 0; i < arr.Length; i++) {
        for (int j = 0; j < arr.Length - i - 1; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
}

void Insert(int[] temp, int i) {
    for (int k = 0; k < temp.Length; k++)
    {
        massive[i, k] = temp[k];
    }
}

int[,] GenerateArray(int t, int i)
{
    int[,] table = new int[t, i];
    Random random = new Random();
    for (int a = 0; a < t; a++)
    {
        for (int b = 0; b < i; b++)
        {
            table[a, b] = random.Next(0, 10);
        }
    }
    return table;
}

void PrintArray(int[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            Console.Write($"{array[a, b]} ");
        }
        Console.WriteLine();
    }
}
