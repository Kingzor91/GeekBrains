// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] massive = { 3, 7, 23, 12 };

int result = 0;
for (int i = 0; i < massive.Length; i++)
{
    if (i % 2 != 0)
    {
        result = result + massive[i];
    }
}
System.Console.WriteLine(result);