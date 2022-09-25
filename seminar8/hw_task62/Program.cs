void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] SpiralConvertion(int[] array)
{
    int n = 4;
    int[,] matrix = new int[n, n];
    int m = n / 2,
        len = n,
        count = 0;
    for (int i = 0; i < m; i++)
    {
        // Заполнение слева направо
        for (int j = 0; j < len; j++) matrix[i, i + j] = array[count++];
        // Заполнение сверху вниз
        for (int j = 1; j < len; j++) matrix[i + j, n - i - 1] = array[count++];
        len -= 2;
        // Заполнение справа налево
        for (int j = len; j >= 0; j--) matrix[n - i - 1, i + j] = array[count++];
        // Заполнение снизу вверх
        for (int j = len; j >= 1; j--) matrix[i + j, i] = array[count++];
    }
    return matrix;
}

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
int[,] matrix = SpiralConvertion(array);
Console.WriteLine("Спирально заполненая матрица: ");
PrintMatrix(matrix);