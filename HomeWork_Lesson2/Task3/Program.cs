// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да; 7 -> да; 1 -> нет

// Это функция, которую можно вызвать. Ввод числа с консоли
int InputInt(string message)    // Параметр - подсказка пользователю
{
    Console.Write(message + " > ");             // Вывод сообщения пользователю
    string? inputValue = Console.ReadLine();     // Ввод строки пользователем
    int result = Convert.ToInt32(inputValue);   // Преобразование в целое введенной строки
    return result;                              // возврат результата
}

// Проверка дней недели
bool ValidateNumberWeek(int number)
{
    if (number > 0 && number < 8)
    {
        return true;
    }
    System.Console.WriteLine("Это не день недели.");
    return false;
}

int number = InputInt("Введите день недели:"); // Вызов функции ввода
if (ValidateNumberWeek(number))    // Проверяем на трехзначность
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}