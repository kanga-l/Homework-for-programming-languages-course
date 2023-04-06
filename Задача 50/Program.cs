//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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

Console.WriteLine("Задайте координаты элемента массива. Введите номер строки");
int coordY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int coordХ = Convert.ToInt32(Console.ReadLine());

if (coordY > lineNumber || coordХ > columnNumber)
{
    Console.WriteLine("Несуществующие координаты");
}

else
{
    Console.Write(newArray[(coordY - 1), (coordХ - 1)]);
}
