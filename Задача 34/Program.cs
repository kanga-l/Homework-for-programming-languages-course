// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Введите количество элементов массива");
int lenght = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[lenght];
RandomNumbers(numbers);
PrintArray(numbers);

void RandomNumbers(int[] numbers)
{
    for (int i = 0; i < lenght; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

int evenNumbers = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
        evenNumbers++;
}
Console.WriteLine($"{evenNumbers} чётных");
