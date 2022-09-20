// 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Ввод чисел останавливается при помощи ввода стоп-слова "stop"

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4


Console.WriteLine("Вводите числа, пока не надоест (стоп-слово 'stop')");

int i = 0;
bool flag = true;       //fix by Zevina
while (flag == true)
{
    string n = Console.ReadLine();
    if (n != "stop" && Convert.ToInt32(n) > 0) i++;
    else if (n == "stop")
    {
        flag = false;
        break;
    }
}

Console.WriteLine("");
Console.WriteLine($"Количество чисел больше нуля = {i}");