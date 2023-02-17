// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет
// 1, 2 -> 4




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
            Console.Write($"{array[i, j]} \t");
        }
    }
    Console.WriteLine();
}

void FindArray(string message)
{
    string[] split = message.Split(",");
    int i = Convert.ToInt32(split[0]);
    int j = Convert.ToInt32(split[1]);
    if (i <= m && j <= n)
    {
        System.Console.WriteLine(array[i - 1, j - 1]);
    }
    else
    {
        System.Console.WriteLine($"Такого числа ({i},{j}) в массиве нет");
    }
}

string Input(string message)    // Параметр - подсказка пользователю
{
    Console.Write(message + " > ");             // Вывод сообщения пользователю
    string? inputValue = Console.ReadLine();    // Ввод строки пользователем
    return inputValue;                          // возврат результата
}

FillArray();
PrintArray();
FindArray(Input("Введите позиции элемента двухмерного массива через запятую"));

