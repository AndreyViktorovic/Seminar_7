// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.WriteLine("введите элемент строки");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите элемент столбца");
int m = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [3,4];
GetRandomMatrix(numbers);
if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("такого числа нет в массиве");
}
else
{
    Console.WriteLine($"значение элемента строки {n} и значение элемента столбца {m} равно {numbers[n-1,m-1]}");
}
PrintArray(numbers);
void GetRandomMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix [i,j] = new Random().Next(-100, 100);
        }
    }   
}
void PrintArray(int[,] matrix)
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