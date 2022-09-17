// 45. Напишите программу, которая будет создавать копию 
// заданного массива с помощью поэлементного копирования.

int[] GetArray(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

int[] array = GetArray(12, -9, 9);
int[] copiedArray = new int[array.Length];
for(int i=0;i<array.Length; i++)
{
    copiedArray[i] = array[i];
}
Console.WriteLine("Старый массив: ");
Console.WriteLine(string.Join(", ", array));
Console.WriteLine("Новый массив: ");
Console.WriteLine(string.Join(", ", copiedArray));