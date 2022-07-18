// Задача 47
//Задайте двумерный массив размером M×N, заполненный случайными вещественными числами.

Console.WriteLine("Введите количество столбцов");
int N = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[M, N];
Random rnd = new Random();

for (int i = 0; i < M; i++)
{
    for (int j =0; j < N; j++)
    {
        array[i, j] = rnd.NextDouble();
        Console.Write( array[i,j] + " ");
    }
    Console.WriteLine();
}