// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5; 78 -> третьей цифры нет; 32679 -> 6

// Это функция, которую можно вызвать. Ввод числа с консоли
int InputInt(string message)    // Параметр - подсказка пользователю
{
    Console.Write(message + " > ");             // Вывод сообщения пользователю
    string? inputValue = Console.ReadLine();     // Ввод строки пользователем
    int result = Convert.ToInt32(inputValue);   // Преобразование в целое введенной строки
    return result;                              // возврат результата
}

// Проверка на 3-хзначность
bool ValidateNumberRank3(int number)
{
    if (number > 99)   // Проверка на трехзначность
    {
        return true;
    }
    System.Console.WriteLine("Третьей цифры нет.");  // Пользователь ввел не трехзначное число
    return false;
}

int number = InputInt("Введите трехзначное число"); // Вызов функции ввода
if (ValidateNumberRank3(number))    // Проверяем на трехзначность
{
    int n = number;
    while (n > 1000)
    {
        n = n / 10;
    }
    int result = n % 10;
    System.Console.WriteLine($"Третья цифра числа {number} равна {result}");
}
