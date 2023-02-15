// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double b1 = Input("b1");
double k1 = Input("k1");
double b2 = Input("b2");
double k2 = Input("k2");

Tuple<double, double> result = Function();
System.Console.WriteLine($"({result.Item1}; {result.Item2})");

double Input(string message)    // Параметр - подсказка пользователю
{
    Console.Write(message + " > ");             // Вывод сообщения пользователю
    double inputValue = Convert.ToDouble(Console.ReadLine());    // Ввод строки пользователем
    return inputValue;                          // возврат результата
}

Tuple<double, double> Function()
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * (b2 - b1) / (k1 - k2) + b1;
    return Tuple.Create(x,y);
}