// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] Sort2DMassive(int[,] massive)
{
    for(int i = 0; i < massive.GetLength(0); i++)
    {
        int sortedSize = massive.GetLength(1) - 1;
        while(sortedSize > 0)
        {
            for(int j = 0; j < sortedSize; j++)
            {
                if(massive[i, j] < massive[i, j + 1])
                {
                    int temp = massive[i, j];
                    massive[i, j] = massive[i, j + 1];
                    massive[i, j + 1] = temp;
                }
            }
            sortedSize--;
        }
    }  
    return massive;  
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
int[,] sortedMatrix = Sort2DMassive(matrix);
Print2DMassive(sortedMatrix);