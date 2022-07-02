void findingNumber(int numberA)
{
    if(numberA > 99)
    {
        Console.WriteLine("Третьей цифрой числа " + numberA + " является " + numberA % 10);
    }
    else
    {
        Console.WriteLine("Третьей цифры числа " + numberA + " нет");
    }
}

findingNumber(645);
findingNumber(78);
//findingNumber(32679); А вот с этим числом проблема(
