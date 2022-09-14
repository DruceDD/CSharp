// 36. Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray(int size, int left, int right)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(left, right + 1);
    }
    return arr;
}

int SumOfOddEl (int[] array)
{
int sum = 0;
for (int i = 1; i < array.Length; i += 2)
{
    sum += array[i];
}
return sum;
}

Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите левую границу массива: ");
int left = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите правую границу массива(включительно): ");
int right = Convert.ToInt32(Console.ReadLine());

int[] array = GetArray(size, left, right);
Console.WriteLine("Сформированный массив: " + string.Join(", ", array));

int sum = SumOfOddEl(array);
Console.WriteLine($"Сумма элементов массива на нечётных позициях = {sum}");

