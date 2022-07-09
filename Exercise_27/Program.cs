// Задача 27
//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int countNumber(int value)
{
    if (value < 10)
        return value;
    int digit = value % 10;
    int nextValue = value / 10;
    return digit + countNumber(nextValue);
}

int myNumber = 9012;
int sum = countNumber(myNumber);
Console.WriteLine("Сумма цифр в числе " + myNumber + " равна " + sum);