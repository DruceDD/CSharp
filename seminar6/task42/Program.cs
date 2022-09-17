// 42. Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
// 67 -> 1000011

void SystemChange(int n, int sys)
{
    if (n != 0)
    {
        SystemChange(n / sys, sys);
        Console.Write(n % sys);
    }
}

Console.WriteLine("Введите десятичное число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите новое основание систему числа (двоичная, троичная, восьмиричная");
int sys = Convert.ToInt32(Console.ReadLine());

SystemChange(n, sys);