// 27. Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
int res = 0;
int d = 0;
while (n > 0)
{
    d = n % 10;
    res = res + d;
    n = n / 10;
}
Console.WriteLine(res);