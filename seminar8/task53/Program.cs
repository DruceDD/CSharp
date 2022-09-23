﻿// 53. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

void GetMatrix(int[,] matrix)
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

void SwapLine(int[,] matrix)
{
    int tempMatrix;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        tempMatrix = matrix[0, j];
        matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
        matrix[matrix.GetLength(0) - 1, j] = tempMatrix;
    }
}

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

Console.Write("Введите кол-во строк: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int j = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[i, j];
Console.WriteLine("Полученая случайная матрица:");
GetMatrix(matrix);
Console.WriteLine("Поменяные местами первая и последняя строки:");
SwapLine(matrix);
PrintMatrix(matrix);