Console.WriteLine("Введите цифру, обозначающую день недели");
int dayNum = Convert.ToInt32(Console.ReadLine());

void dayOfTheWeek(int dayNum) 
{
    if (dayNum == 6 || dayNum == 7) 
    {
        Console.WriteLine("Это выходной!");
    }
    else if (dayNum < 1 || dayNum > 7) 
    {
        Console.WriteLine("Ошибка! Введите другую цифру");
    }
  else Console.WriteLine("Это рабочий день!");
}

dayOfTheWeek(dayNum);
