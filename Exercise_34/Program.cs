// Задача 34
//Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int lenght = 5;
int [] newArr = new int[lenght];
Random rnd = new Random();
int count = 0;

for(int i = 0; i < lenght; i++)
{
    newArr[i] = rnd.Next(100, 999);
    Console.Write(newArr[i] + " ");
    if(newArr[i] % 2 == 0 )
    {
        count++;
    }
}

Console.WriteLine();
Console.WriteLine("Количество чётных элементов " + count);