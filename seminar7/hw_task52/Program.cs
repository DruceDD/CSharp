// 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void getMatrix(double[,] matrix)
{
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(-10, 11);
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

double[] avgSumColumnMatrix(double[,] matrix)
{
    double[] avg = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            avg[j] += matrix[i, j];
        }
        avg[j] = Math.Round(avg[j]/matrix.GetLength(0), 1);
    }
    return avg;
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[m, n];
Console.WriteLine("Получили рандомную матрицу: ");
getMatrix(matrix);
Console.WriteLine();
Console.WriteLine($"Среднее арифметическое каждого столбца:\n {string.Join("; ", avgSumColumnMatrix(matrix))}");