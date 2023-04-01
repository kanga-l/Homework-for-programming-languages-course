// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Введите количество элементов массива");
int lenght = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[lenght];
RandomNumbers(numbers);
PrintArray(numbers);

int sum = 0;

for (int n = 0; n < numbers.Length; n += 2)
    sum = sum + numbers[n];

Console.WriteLine($"{sum}");

void RandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-10000, 10000);
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
