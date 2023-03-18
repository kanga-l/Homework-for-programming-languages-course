// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите произвольное натуральное число");

int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine("третьей цифры не существует");
}

else
if (number > 99 && number < 1000)
{
    Console.WriteLine(number % 10);
}

else
{
    while (number > 999)
        number = number / 10;
    Console.WriteLine(number % 10);
}