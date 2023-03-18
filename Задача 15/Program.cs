// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру");

int number = Convert.ToInt32(Console.ReadLine());

if (number > 0 && number < 6)
{
    Console.WriteLine("Будний день");
}

else if (number == 7 || number == 6)
{
    Console.WriteLine("Выходной день");
}

else
{
    Console.WriteLine("Такого дня недели не существует");
}
