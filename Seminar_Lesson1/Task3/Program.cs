//Напишите программу вычисления функции:
// x = f(a) (делаем куб числа)
Console.WriteLine("введите число");
string value = Console.ReadLine();
int number = Convert.ToInt32(value);
int result = number * number * number;
Console.WriteLine($"куб числа {number} равен {result}");