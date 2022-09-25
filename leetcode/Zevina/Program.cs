int n = 0;
while (n == 0)
{
    try
    {
        Console.Write("Введите размер квадрата: ");
        n = Convert.ToInt32(Console.ReadLine());
    }
    catch (FormatException e)
    {
        Console.WriteLine("Размер - целое число, больше 0");
        Console.WriteLine("Попробуйте еще раз");
    }
}
var matrix = new int[n, n];
var rand = new Random();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = rand.Next(100);
    }
}
Console.WriteLine("Исходная матрица: ");
MatrixOutput(matrix);
// создаем массив
int[] arr = GetArray(matrix);
Console.WriteLine("Исходный массив:");
ArrayOutput(arr);

// сортируем массив
Array.Sort(arr);
Console.WriteLine("После сортировки:");
ArrayOutput(arr);

// преобразуем матрицу
matrix = SpiralConvertion(arr);

Console.WriteLine("Результат: ");
MatrixOutput(matrix);


void MatrixOutput(int[,] mx)
{
    int n = mx.GetLength(0);
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write("{0,4}", mx[i, j]);
        }
        Console.WriteLine();
    }
}

void ArrayOutput(int[] arr)
{
    Console.WriteLine(String.Join(", ", arr));
    Console.WriteLine();
}

int[] GetArray(int[,] mx)
{
    return mx.Cast<int>().ToArray();
}

int[,] SpiralConvertion(int[] arr)
{
    var n = (int)Math.Sqrt(arr.Length);
    var matrix = new int[n, n];

    int m = n / 2 + n % 2,
        len = n,
        count = 0;

    for (int i = 0; i < m; i++)
    {
        // Верх
        for (int j = 0; j < len; j++) matrix[i, i + j] = arr[count++];
        // Право
        for (int j = 1; j < len; j++) matrix[i + j, n - i - 1] = arr[count++];
        len -= 2;
        // Низ
        for (int j = len; j >= 0; j--) matrix[n - i - 1, i + j] = arr[count++];
        // Лево
        for (int j = len; j >= 1; j--) matrix[i + j, i] = arr[count++];
    }

    return matrix;
}