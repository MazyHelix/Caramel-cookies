// Задача 25 
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

Console.WriteLine("Введите число A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int numberB = Convert.ToInt32(Console.ReadLine());

double power (double numberA, double numberB)
{
    double result = 1;
    result = Math.Pow(numberA, numberB);   
    return result;   
}

double newPower = power(2,4);
Console.WriteLine("Возведение числа " + numberA + " в степень " + numberB + " равно " + newPower);