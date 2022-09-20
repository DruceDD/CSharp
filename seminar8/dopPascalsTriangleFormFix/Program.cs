//Доп. задание. Вывести первые N строк треугольника Паскаля (N = 5, чтоб не ломалась форма), но равнобедренно!

void PrintTriangle(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == 0) Console.Write("\t");
            else Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void FillTriangle(int[,] matr)
{
    for (int i = 1; i < matr.GetLength(0); i++)
    {
        for (int j = 1; j < matr.GetLength(1) - 1; j++)
        {
            matr[i, j] = matr[i - 1, j - 1] + matr[i - 1, j + 1]; 
        }
    }
    
}

Console.Write("Введите количество строк треугольника Паскаля: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] triangle = new int[n, (n * 2) + 1];
triangle[0, n] = 1;

Console.WriteLine();
FillTriangle(triangle);
PrintTriangle(triangle);
Console.WriteLine();