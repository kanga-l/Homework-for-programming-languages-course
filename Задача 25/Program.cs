// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

System.Console.WriteLine("Введите натуральное число");

int bas = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите показатель степени");

int exp = Convert.ToInt32(Console.ReadLine());

double result = Math.Pow(bas, exp);

Console.WriteLine(result);