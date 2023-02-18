// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int m = Input("Введите M");
int n = Input("Введите N");
ShowNumbers(m, n, 0);

int Input(string message)
{
    Console.Write(message + " > ");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

void ShowNumbers(int m, int n, int sum)
{
    if (m > n)
    {
        Console.Write($"{sum} ");
        return;
    }
    sum = sum + m;
    ShowNumbers(m + 1, n, sum);
}