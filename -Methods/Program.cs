// Ввод числа из консоли.
int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Заполнение массива случайными числами от -10 до 10.
int[,] GetMatrix(int rows, int columns, int leftRange = -10, int rightRange = 10)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}

// Печать массива в терминал.
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

// Сортировка матрицы по линия.
void SortByLineMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            int minPosition = j;
            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, k] < matrix[i, minPosition])
                {
                    minPosition = k;
                }
            }
            int temp = matrix[i, j];
            matrix[i, j] = matrix[i, minPosition];
            matrix[i, minPosition] = temp;
        }
    }
}

/* Рандом без повторений.
void GetMatrix(int[] array, int[,] cubeMatrix)
matrix[i, j] = array[count++]; */
int[] NewRandom(int[] randNew)
{
    int n = 0;
    Random rand = new Random();
    for (int d = 0; d < randNew.Length; d++)
    {
        n = rand.Next(10, 100);
        if (!randNew.Contains<int>(n))
        {
            randNew[d] = n;
        }
        else d--;
    }
    return randNew;
}

// Спиральное заполнение матрицы
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

// Поиск количества повторений элементов в матрице
void SearchElementOfMatrix(int[,] matrix)
{
    int count = 0;
    for (int k = 0; k < 10; k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == k) count++;
            }
        }
        if (count != 0)
        {
            Console.WriteLine($"Эелемент {k} встречается {count} раз");
            count = 0;
        }
    }
}

// Удаление строки и столбца с минимальным элементом
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

// Среднее арифметическое матрицы по столбцам.
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

/* Флаг остановки по слову.
Console.WriteLine("Вводите числа, пока не надоест (стоп-слово 'stop')");
int i = 0;
bool flag = true; */       
while (flag == true)
{
    string n = Console.ReadLine();
    if (n != "stop" && Convert.ToInt32(n) > 0) i++;
    else if (n == "stop")
    {
        flag = false;
        break;
    }
}