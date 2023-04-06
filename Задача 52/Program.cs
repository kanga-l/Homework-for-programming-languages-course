// Задайте двумерный массив из целых чисел. Найдите 
// среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите количество строк двумерного массива");
int lineNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива");
int columnNumber = Convert.ToInt32(Console.ReadLine());

int[,] newArray = new int[lineNumber, columnNumber];

Random random = new Random();

for (int i = 0; i < newArray.GetLength(0); i++)

{
    for (int j = 0; j < newArray.GetLength(1); j++)
    {
        newArray[i, j] = random.Next(1000);
    }
}

for (int y = 0; y < newArray.GetLength(0); y++)
{
    for (int x = 0; x < newArray.GetLength(1); x++)
    {
        Console.Write(newArray[y, x] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine("Среднее арифметическое чисел, находящихся в каждом столбце:");

for (int y = 0; y < newArray.GetLength(1); y++)
{
    double sum = 0;
    for (int x = 0; x < newArray.GetLength(0); x++)
    {
        sum += newArray[x, y];
    }
    double average = sum / lineNumber;
    Console.Write($"{Math.Round(average, 2)} \t");
}
