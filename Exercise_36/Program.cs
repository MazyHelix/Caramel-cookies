// Задача 36
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int lenght = 5;
int [] randomNumbers = new int[lenght];
Random rnd = new Random();
int oddSum = 0;

for(int i = 0; i < lenght; i++)
{
    randomNumbers[i] = rnd.Next(-10, 10);
    Console.Write(randomNumbers[i] + " ");
    if(i % 2 != 0)
    {
        oddSum += randomNumbers[i];
    }   
}

Console.WriteLine();
Console.WriteLine("Сумма элементов, стоящих на нечётной позиции равна " + oddSum);