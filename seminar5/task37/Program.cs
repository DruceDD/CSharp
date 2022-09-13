// 37. Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и 
// предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.WriteLine("Введите длину массива:");
int size = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[size];
Random rand = new Random();
for (int i = 0; i < size; i++)
{
    arr[i] = rand.Next(0, 10);
}
Console.WriteLine("Сформированный массив: " + string.Join(", ", arr));

int[] newArr = new int[(arr.Length + 1) / 2];
for (int i = 0; i < newArr.Length; i++)
{
    newArr[i] = arr[i] * arr[arr.Length - 1 - i];
}
if (arr.Length % 2 != 0)
{
    newArr[newArr.Length - 1] = arr[arr.Length / 2];
}
Console.WriteLine("Новый массив: " + string.Join(", ", newArr));