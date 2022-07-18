﻿// Задача 52
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите количество строк");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int N = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[M, N];
Random rnd = new Random();

for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++)
    {
        array[i, j] = rnd.Next(-10, 10);
        Console.Write( array[i,j] + " ");
    }
    Console.WriteLine();
}

for (int j = 0; j < N; j++)
{
    double sum = 0;
    for (int i = 0; i < M; i++)
    {
        sum += array[i, j];
    }
    Console.WriteLine("Среднее арифметечкое по столбцам равно " + sum / M);
}