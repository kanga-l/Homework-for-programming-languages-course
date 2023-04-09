// Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.

Console.WriteLine("Введите количество строк первой матрицы");
int lineNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов первой матрицы");
int columnNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов второй матрицы");
int secondColumnNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int[,] firstArray = new int[lineNumber, columnNumber];
Random random = new Random();

for (int i = 0; i < firstArray.GetLength(0); i++)
{
    for (int j = 0; j < firstArray.GetLength(1); j++)
    {
        firstArray[i, j] = random.Next(1, 100);
    }
}

int[,] secondArray = new int[columnNumber, secondColumnNumber];
Random rand = new Random();

for (int i = 0; i < secondArray.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        secondArray[i, j] = rand.Next(1, 100);
    }
}

for (int y = 0; y < firstArray.GetLength(0); y++)
{
    for (int x = 0; x < firstArray.GetLength(1); x++)
    {
        Console.Write(firstArray[y, x] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int y = 0; y < secondArray.GetLength(0); y++)
{
    for (int x = 0; x < secondArray.GetLength(1); x++)
    {
        Console.Write(secondArray[y, x] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine("Произведение двух матриц:");

int[,] productArray = new int[columnNumber, columnNumber];

for (int i = 0; i < firstArray.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        for (int k = 0; k < firstArray.GetLength(1); k++)
        {
            productArray[i, j] += firstArray[i, k] * secondArray[k, j];
        }
    }
}

for (int y = 0; y < productArray.GetLength(0); y++)
{
    for (int x = 0; x < productArray.GetLength(1); x++)
    {
        Console.Write(productArray[y, x] + "\t");
    }
    Console.WriteLine();
}