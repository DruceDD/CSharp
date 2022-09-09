// Отсортировать принимаемый массив по возрастанию

Console.WriteLine("Введите длину массива:");
int l = Convert.ToInt32(Console.ReadLine());
int n = 0;

int[] array = new int[l];
for (n = 0; n < l; n++)
{
    Console.WriteLine("Введите элементы массива:");
    array[n] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Введенный массив:");
for(n = 0; n < l; n++)
{
Console.Write(array[n]);
}
Console.WriteLine("");
Console.WriteLine("Отсортированный массив:");

int i = 0;
int j = 0;
int a = l;

while (j < l - 1)
{
    while (i < a - 1)
    {
        if(array[i] > array[i + 1])
        {
        int t = array[i];
        array[i] = array[i + 1];
        array[i + 1] = t;
        i++;
        }
        else
        {
            i++;
        }
    }
j++;
a = a - 1;
i = 0;
}

for(n = 0; n < l; n++)
{
Console.Write(array[n]);
}