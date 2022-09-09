// 25. Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень:");
int s = Convert.ToInt32(Console.ReadLine());

int res = 1;
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
else
{
  Console.WriteLine("Степень должна быть натуральным числом!");
}