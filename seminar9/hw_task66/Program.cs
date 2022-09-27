// 66. Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbersFromMtoN(int m, int n)
{
    int sum = 0;
    if (m == n) return m;
    else if (m < n)
    {
        sum = m + SumNumbersFromMtoN(m + 1, n);
        return sum;
    }
    else return -1;
}

int m = ReadNumber("Введите M: ");
int n = ReadNumber("Введите N: ");
if (n > m) Console.WriteLine(SumNumbersFromMtoN(m, n));
if (m > n) Console.WriteLine(SumNumbersFromMtoN(n, m));