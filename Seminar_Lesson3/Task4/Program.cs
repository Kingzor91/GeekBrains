// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


int InputInt(string message)
{
    Console.Write(message + " > ");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

int n = InputInt($"Введите число N");

for (int i = 1; i <= n; i++)
{
    int result = i * i;
    System.Console.Write($"{result}, ");
}