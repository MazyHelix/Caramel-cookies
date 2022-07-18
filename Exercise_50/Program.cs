// Задача 50
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите количество строк");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер элемента строки");
int i0 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер элемента столбца");
int j0 = Convert.ToInt32(Console.ReadLine());

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

if (i0 >= M || j0 >= N || i0 < 0 || j0 < 0)
{
    Console.WriteLine("Такого числа в массиве нет");
}
else
{
    Console.WriteLine(
        "Элемент c номером стороки {0} и номером столбца {1} это {2}", i0, j0, array[i0, j0]);
}