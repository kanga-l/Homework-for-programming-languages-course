// Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементами массива.

Console.WriteLine("Введите количество элементов массива");
int lenght = Convert.ToInt32(Console.ReadLine());

double[] numbers = new double[lenght];
RandomNumbers(numbers);

PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int n = 0; n < numbers.Length; n++)
{
    if (numbers[n] > max)
    {
        max = numbers[n];
    }
    if (numbers[n] < min)
    {
        min = numbers[n];
    }
}

Console.WriteLine($"Максимальный элемент = {max}, минимальный элемент = {min}");
Console.WriteLine($"Разница = {max - min}");

void RandomNumbers(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}