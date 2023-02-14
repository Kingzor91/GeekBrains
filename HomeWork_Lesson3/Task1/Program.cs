// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не используйте строки
// 14212 -> нет; 12821 -> да; 23432 -> да

int InputInt(string message)    // Параметр - подсказка пользователю
{
    Console.Write(message + " > ");             // Вывод сообщения пользователю
    string? inputValue = Console.ReadLine();     // Ввод строки пользователем
    int result = Convert.ToInt32(inputValue);   // Преобразование в целое введенной строки
    return result;                              // возврат результата
}

// Проверка на 5 значность
bool Validate(int number)
{
    if (number > 10000 && number < 100000)
    {
        return true;
    }
    System.Console.WriteLine("Число не пятизначное.");
    return false;
}

int number = InputInt("Введите трехзначное число"); // Вызов функции ввода

if (Validate(number))    // Проверяем на трехзначность
{
    System.Console.WriteLine(number);
}