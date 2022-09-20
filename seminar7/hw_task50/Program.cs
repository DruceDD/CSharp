// 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

void getMatrix(int[,] matrix)
{
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(-10, 11);
            Console.Write($"{matrix[i, j]}   ");
        }
        Console.WriteLine();
    }
}

void searchFromMatrix(int[,] matrix)
{
    bool flag = false;
    Console.Write("Введите строку поиска: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите столбец поиска: ");
    int b = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == a && j == b)
            {
                Console.WriteLine($"Число на указаной позиции: {matrix[i, j]}");
                flag = true;
                break;
            }
        }
    }
    if (!flag) Console.WriteLine("Такого позиции в массиве нет! (:");
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];
Console.WriteLine("Получили рандомную матрицу: ");
getMatrix(matrix);
Console.WriteLine();
searchFromMatrix(matrix);