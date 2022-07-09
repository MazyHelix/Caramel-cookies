// Задача 29
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] massive = new int[8];
Random ranNumber = new Random();
for (int i = 0; i < 8; i++)
{
    massive[i] = ranNumber.Next(0, 100);
    Console.Write(massive[i] + ", ");
}