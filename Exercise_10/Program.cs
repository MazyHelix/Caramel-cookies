// Задача № 10

void randomSecondNumber(int start, int finish)
{
    int numberA = new Random().Next(start,finish);
    Console.WriteLine(numberA);
    int secondnum = (numberA /10) % 10;
    Console.WriteLine("Вторая цифра числа " + numberA + " является " + secondnum);
}

randomSecondNumber(100,999);
