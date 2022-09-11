// 27. Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
int res = 0;
if (n > 0)
{
    while (n > 0)
    {
        res = res + n % 10;
        n = n / 10;
    }
    Console.WriteLine(res);
}
else if (n < 0)
{
    n = n * -1;
    while (n > 0)
    {
        res = res + n % 10;
        n = n / 10;
    }
Console.WriteLine(res);
}