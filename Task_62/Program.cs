// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void Print2DMassive(int[,] massive)
{
    for(int i = 0; i < massive.GetLength(0); i++)
    {
        for(int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] Create2DMassive()
{
    int[,] massive = new int[4, 4];
    int value = 1;
    for(int j = 0; j < 4; j++)
    {
        massive[0, j] = value;
        value++;
    }
    for(int i = 1; i < 4; i++)
    {
        massive[i, 3] = value;
        value++;
    }
    for(int j = 2; j >= 0; j--)
    {
        massive[3, j] = value;
        value++;
    }
    for(int i = 2; i >= 1; i--)
    {
        massive[i, 0] = value;
        value++;
    }
    for(int j = 1; j < 3; j++)
    {
        massive[1, j] = value;
        value++;
    }
    for(int j = 2; j >= 1; j--)
    {
        massive[2, j] = value;
        value++;
    }
    return massive;
}

int[,] matrix = Create2DMassive();
Print2DMassive(matrix);