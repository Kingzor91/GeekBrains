// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] massive = { 3, 7, 22, 2, 78 };

int min = int.MaxValue;
int max = int.MinValue;
for (int i = 0; i < massive.Length; i++)
{
    if (min > i) min = massive[i];
    if (max < i) max = massive[i];
}
int result = max - min;
System.Console.WriteLine(result);
