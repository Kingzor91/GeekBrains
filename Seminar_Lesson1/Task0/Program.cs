Console.Write("Введите число > ");
string strValue = Console.ReadLine();
int value;
value = Convert.ToInt32(strValue);

int result = value * value;

Console.WriteLine($"Квадрат числа {value} равен {result}");