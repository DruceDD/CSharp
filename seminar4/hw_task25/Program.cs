// 25. Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число:");
double n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень:");
int s = Convert.ToInt32(Console.ReadLine());

double res = 1;
int i = 0;
if (s > 0)
{
    while (i < s)
    {
    res = res * n;
    i++;
    }   
Console.WriteLine(res);    
}
else if (s == 0)
{
  Console.WriteLine("Ноль, не натурально число");
  Console.WriteLine($"Но раз вы здесь - любое число в степени 0 = 1");
}
else if (s < 0)
{
  while (i > s)
    {
    res = res / n;
    i = i - 1;
    }  
  Console.WriteLine("По заданию - степень должна быть натуральным числом");
  Console.WriteLine($"Но раз вы здесь - ответ 1/({n}^{-s}), то есть {res}");
}