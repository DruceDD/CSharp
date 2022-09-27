// 65. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNumbers1toN(int n, int m)
{
    if (n < m) return;
    else
    {
        PrintNumbers1toN(n-1, m);
        Console.Write(n + " ");
    }
}

int m = ReadNumber("Введите M: ");
int n = ReadNumber("Введите N: ");
PrintNumbers1toN(n, m);