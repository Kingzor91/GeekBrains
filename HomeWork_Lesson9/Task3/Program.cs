// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int m = Input("Введите M");
int n = Input("Введите N");
System.Console.WriteLine(recursion(m, n));

int Input(string message)
{
    Console.Write(message + " > ");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

int recursion(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return recursion(m - 1, 1);
    } 
    else
    {
        return recursion(m - 1, recursion(m, n - 1));
    }
}