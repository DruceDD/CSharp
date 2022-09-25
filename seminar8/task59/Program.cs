// 59. Задайте двумерный массив из целых чисел. Напишите программу, которая удалит 
// строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m,n];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(10, 100);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] SearchMinElementOfMatrix(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];

    int minElement = matrix[0, 0];//мин элемент
    int minRow = 0;//индекс строки с мин элементом
    int minColumn = 0;//индекс столбца с мин элементом

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < minElement) //поиск минимального элемента
            {
                minElement = matrix[i, j];//минимальный элемент
                minRow = i;//индекс строки
                minColumn = j;//индекс столбца
            }
        }
    }
    int rowOffset = 0;//смещение для исходной матрицы по строке
    int columnOffset = 0;//смещение для исходной матрицы по столбцу
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if (i == minRow) rowOffset++;//если лишняя строка -> смещение = 1, иначе = 0
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (j == minColumn) columnOffset++;//если лишний столбец -> смещение = 1, иначе = 0
            newMatrix[i, j] = matrix[i + rowOffset, j + columnOffset];//записать в новую матрицу данные из старой с учетом всех смещений
        }
        columnOffset = 0;//обнулить смещение по столбцу
    }
    return newMatrix;
}

// void SearchMinElementOfMatrix(int[,] matrix)
// {
//     int min = matrix[0, 0];
//     int minRow = 0;
//     int minColumn = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (matrix[i, j] < min)
//             {
//                 min = matrix[i, j];
//                 minRow = i;
//                 minColumn = j;
//             }
//         }
//     }
//     Console.WriteLine($"Наименьший элемент - {min} на позиции [{minRow},{minColumn}]");
//     Console.WriteLine();
//     int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         if (i == minRow) continue;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j == minColumn) continue;
//             Console.Write($"{matrix[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

Console.Write("Введите кол-во строк: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int j = Convert.ToInt32(Console.ReadLine());
int[,] matrix = GetMatrix(i, j);
Console.WriteLine("Полученая случайная матрица:");
PrintMatrix(matrix);
// GetMatrix(matrix);
Console.WriteLine("Измененная матрица:");
int[,] newMatrix = SearchMinElementOfMatrix(matrix);
PrintMatrix(newMatrix);
// SearchMinElementOfMatrix(matrix);