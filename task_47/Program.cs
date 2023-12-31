﻿//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("введите количество строк массива m =");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество столбцов массива n =");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[rows, columns];
GetRandomMatrix(numbers);
PrintArray(numbers);
void GetRandomMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Convert.ToDouble(new Random().Next(-100, 100))/10;
        }
    }
}
void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
