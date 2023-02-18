// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int m = Input("Введите M");
int n = Input("Введите N");
ShowNumbers(m, n);

int Input(string message)
{
    Console.Write(message + " > ");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

void ShowNumbers(int m, int n)
{
    if (m > n) return;
    if (m % 2 == 0) Console.Write($"{m} ");
    ShowNumbers(m + 1, n);
}