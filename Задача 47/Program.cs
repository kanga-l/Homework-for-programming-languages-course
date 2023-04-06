//Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введите количество строк двумерного массива");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива");
int m = Convert.ToInt32(Console.ReadLine());

double[,] newArray = new double[m, n];

Random random = new Random();

for (int i = 0; i < newArray.GetLength(0); i++)
{
    for (int j = 0; j < newArray.GetLength(1); j++)
    {
        newArray[i, j] = random.NextDouble() * 100;
    }
}

for (int y = 0; y < newArray.GetLength(0); y++)
{
    for (int x = 0; x < newArray.GetLength(1); x++)
    {
        Console.Write($"{Math.Round(newArray[y, x], 2)} \t");
    }
    Console.WriteLine();
}
