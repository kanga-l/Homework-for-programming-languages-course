// Напишите программу, которая заполнит спирально массив 4 на 4.

int n = 4;
int[,] newArray = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= newArray.GetLength(0) * newArray.GetLength(1))
{
    newArray[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < newArray.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= newArray.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > newArray.GetLength(1) - 1)
        j--;
    else
        i--;
}

for (int y = 0; y < newArray.GetLength(0); y++)
{
    for (int x = 0; x < newArray.GetLength(1); x++)
    {
        Console.Write(newArray[y, x] + "\t");
    }
    Console.WriteLine();
}
