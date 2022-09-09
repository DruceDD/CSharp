// разворот числа
Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine()); //исходное число
int tempNumber = number; //число, которое будем делить на 10
int reversedNumber = 0; //развернутое число

while (tempNumber > 0)
{
    int digit = tempNumber % 10;
    reversedNumber = reversedNumber * 10 + digit;
    tempNumber = tempNumber / 10;
}
//Console.WriteLine($"Резвернутое число = {reversedNumber}");

if (number == reversedNumber)
{
    Console.WriteLine("Число полиндром");
}
else 
{
    Console.WriteLine("Число не полиндром");
}