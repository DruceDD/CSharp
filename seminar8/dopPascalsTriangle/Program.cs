//Доп. задание. Вывести первые N строк треугольника Паскаля (15)

void PrintTriangle(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == 0) Console.Write(" ");
            else Console.Write($" {matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillTriangle(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j <= i; j++)
        {
            if (j == i || j == 0)
            {
                matr[i, j] = 1;
            }
            else
            {
                matr[i, j] = matr[i - 1, j - 1] + matr[i - 1, j];
            }
        }
    }
}

Console.Write("Введите количество строк треугольника Паскаля: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] triangle = new int[n, n];
FillTriangle(triangle);
PrintTriangle(triangle);