﻿// Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Write("Введите натуральное число");
Console.WriteLine();
int number = Convert.ToInt32(Console.ReadLine());

int count = 1;
NumbersDescend(number, count);

void NumbersDescend(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        NumbersDescend(n, count + 1);
        Console.Write(count + ", ");
    }
}
