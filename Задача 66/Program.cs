// Задайте значения M и N. Напишите программу, которая
// найдёт сумму натуральных элементов в промежутке от M до N.


Console.Write("Введите натуральное число M:");
Console.WriteLine();
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите натуральное число N:");
Console.WriteLine();
int n = Convert.ToInt32(Console.ReadLine());

int SumMN(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}

Console.Write(SumMN(m - 1, n));
