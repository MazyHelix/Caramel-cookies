// Задача 38
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

int lenght = 5;
double[] findDiff = new double[lenght];
Random rnd = new Random();
for(int i = 0; i < lenght; i++)
{
    findDiff[i] = rnd.Next(1, 100);
    Console.Write(findDiff[i] + " ");
}

double maxNumber = findDiff[0];
double minNumber = findDiff[0];

for(int i = 0; i < lenght; i++)
{
    if(maxNumber > findDiff[i])
    {
        maxNumber = findDiff[i];
    }
    if(minNumber < findDiff[i])
    {
        minNumber = findDiff[i];
    }
}
double result = maxNumber - minNumber;
Console.WriteLine();
Console.WriteLine("Разность между min и max значениями элементов массива равна " + result);