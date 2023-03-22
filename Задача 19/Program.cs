// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

System.Console.WriteLine("Введите пятизначное число");

int numberFull = Convert.ToInt32(Console.ReadLine());

int firstDigit = (numberFull / 10000);

int fifthDigit = (numberFull % 10);

int secondDigit = ((numberFull / 1000) % 10);

int forthDigit = ((numberFull % 100) / 10);

if (firstDigit == fifthDigit && secondDigit == forthDigit)
{
    System.Console.Write("палиндром");
}

else
{
    System.Console.Write("не палиндром");
}