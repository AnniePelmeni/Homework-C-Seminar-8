// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void CountSmallestSum(int[,] massive)
{
    int[] allSums = new int[massive.GetLength(0)];
    for(int i = 0; i < massive.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < massive.GetLength(1); j++)
        {
            sum = sum + massive[i, j];
        }
        allSums[i] = sum;
    }
    int minSum = allSums[0];
    int rowNumber = 0;
    for(int k = 0; k < allSums.Length; k++)
    {
        if(allSums[k] < minSum) 
        {
            minSum = allSums[k];
            rowNumber = k + 1;
        }
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {rowNumber}");    
}

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
    int rows = new Random().Next(1, 10);
    int columns = new Random().Next(1, 10);
    if(rows == columns) rows++;
    int[,] massive = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            massive[i, j] = new Random().Next(1, 10);
        }
    }
    return massive;
}

int[,] matrix = Create2DMassive();
Print2DMassive(matrix);
CountSmallestSum(matrix);