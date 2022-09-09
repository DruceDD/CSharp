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
    Console.WriteLine("Ну ладно, сделаю все сам!");
    int[] array = new int[8];
    Random rand = new Random();
    for (n = 0; n < array.Length; n++)
    array[n] = rand.Next(1, 100);
    Console.WriteLine("Сделаный за тебя массив:");
    Console.WriteLine(string.Join(" ", array));
}