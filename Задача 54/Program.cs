// Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.

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
        newArray[i, j] = random.Next(100);
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

Console.WriteLine("Тот же массив, с элементами каждой строки, упорядоченными по убыванию:");

for (int i = 0; i < newArray.GetLength(0); i++)
{
    for (int j = 0; j < newArray.GetLength(1); j++)
    {
        for (int l = 0; l < newArray.GetLength(1) - 1; l++)
        {
            if (newArray[i, l] < newArray[i, l + 1])
            {
                int temp = newArray[i, l + 1];
                newArray[i, l + 1] = newArray[i, l];
                newArray[i, l] = temp;
            }
        }
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