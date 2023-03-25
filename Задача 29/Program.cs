// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// Random rnd = new Random();

// int value = rnd.Next(100);

// Console.WriteLine(value);

int[] numbers = new int[8];
Console.Write("[");

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(0, 11);
    Console.Write(" " + Method(i) + " ");
}
Console.Write("]");

int Method(int a)
{
    return numbers[a];
}