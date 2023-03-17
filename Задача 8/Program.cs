// Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите целое число");

int number = Convert.ToInt32(Console.ReadLine());

for (int a = 1; a <= number; a++)
{
    if (a % 2 == 0)
        System.Console.Write(a + ", ");
}
