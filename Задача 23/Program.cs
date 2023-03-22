// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

System.Console.WriteLine("Введите натуральное число");

int n = Convert.ToInt32(Console.ReadLine());

for (int a = 1; a <= n; a++)
{
    int result = (int)Math.Pow(a, 3);
    System.Console.Write(result + ", ");
}