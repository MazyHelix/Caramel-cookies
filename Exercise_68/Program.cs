// Задача 68
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

Console.Write("Ввведите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввведите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int Akkerman(int mNumber, int nNumber)
{
    if (mNumber == 0) return nNumber + 1;
    if (nNumber == 0) return Akkerman(mNumber - 1, 1);
    return Akkerman(mNumber -1, Akkerman(mNumber, nNumber-1));;
}

Console.WriteLine(Akkerman(m, n));