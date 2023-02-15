// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

string Input(string message)    // Параметр - подсказка пользователю
{
    Console.Write(message + " > ");             // Вывод сообщения пользователю
    string? inputValue = Console.ReadLine();    // Ввод строки пользователем
    return inputValue;                          // возврат результата
}

List<int> ToList(string message)
{
    string[] s = message.Split(",");
    List<int> list = new List<int>();
    for (int i = 0; i < s.Length; i++)
    {
        list.Add(Convert.ToInt32(s[i]));
    }
    return list;
}

int Count(List<int> list)
{
    int count = 0;
    for (int i = 0; i < list.Count; i++)
    {
        if (list[i] > 0)
        {
            count++;
        }
    }
    return count;
}

List<int> list = ToList(Input("Введите с клавиатуры М числе разделенных запятой."));
System.Console.WriteLine(Count(list));
