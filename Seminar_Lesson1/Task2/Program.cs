//пользователь вводит число дня недели, а программа выдает его название
Console.WriteLine("введите номер дня недели");
string dayofweek = Console.ReadLine();
int numberday = Convert.ToInt32(dayofweek);
if (numberday < 8 && numberday > 0) {
    string[] weeks = new string[7] { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
    System.Console.WriteLine(weeks[numberday - 1]);
}
else {
    System.Console.WriteLine("это не день недели");
}
