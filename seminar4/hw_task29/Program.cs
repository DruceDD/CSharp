// 29. Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран. Данные вводятся с консоли пользователем

Console.WriteLine("Введите длину массива(по заданию длина массива 8 символов):");
int l = Convert.ToInt32(Console.ReadLine());
int n = 0;

if (l == 8)
{
Console.WriteLine("Введите поочередно элементы массива:");
int[] array = new int[l];
for (n = 0; n < l; n++)
{
    array[n] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Введенный массив:");
Console.WriteLine(string.Join(" ", array));
}
else
{
    Console.WriteLine("Написано же 8!!!");
}