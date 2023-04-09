// Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

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
        newArray[i, j] = random.Next(1, 100);
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

int SumLineElements(int[,] newArray, int i)
{
    int sumLine = newArray[i, 0];
    for (int j = 1; j < newArray.GetLength(1); j++)
    {
        sumLine += newArray[i, j];
    }
    return sumLine;
}

int minSumLine = 0;
int sumLine = SumLineElements(newArray, 0);
for (int i = 1; i < newArray.GetLength(0); i++)
{
    int tempSumLine = SumLineElements(newArray, i);
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
}

Console.WriteLine("строкa с наименьшей суммой элементов - " + (minSumLine + 1));