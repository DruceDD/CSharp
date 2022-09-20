// 51. Задайте двумерный массив. Найдите сумму элементов, находящихся 
// на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// Доп. условие для 51 задачи: сделать суммирование в один цикл. Матрица может быть прямоугольный

void getMatrix(int[,] matrix)
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

int SumMainDiagonalMatrix(int[,] matrix)
{
    int sum = 0;
    int minLength;
    if (matrix.GetLength(0) >= matrix.GetLength(1))
    {
        minLength = matrix.GetLength(1);
    }
    else
    {
        minLength = matrix.GetLength(0);
    }
    for (int i = 0; i < minLength; i++)
    {
        sum += matrix[i, i];
    }
    return sum;
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
Console.WriteLine("Получили рандомную матрицу: ");
getMatrix(matrix);
Console.WriteLine();
int sum = SumMainDiagonalMatrix(matrix);
Console.WriteLine($"Cумма главной диагонали: {sum}");