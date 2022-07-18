// Задача 43
// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

void coordinate(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    if(k1 == k2 && b1 == b2)
    {
        Console.WriteLine("Прямые не пересекаются");
    }
    else 
    {
        Console.WriteLine("Прямые пересекаются в точке ({0}; {1})", x, y);
    }
}
coordinate(2, 5, 4, 9);