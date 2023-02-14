// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] massive = { 345, 897, 568, 234 };

int result = 0;
for (int i = 0; i < massive.Length; i++)
{
    if (massive[i] % 2 == 0)
    {
        result++;
    }
}
System.Console.WriteLine(result);