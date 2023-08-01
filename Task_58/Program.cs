// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] FindMassivesProduct(int[,] massive1, int[,] massive2)
{
    int[,] massive3 = new int[massive1.GetLength(0),massive1.GetLength(1)];
    for (int i = 0; i < massive1.GetLength(0); i++)
    {
        for (int j = 0; j < massive2.GetLength(1); j++)
        {
            for (int k = 0; k < massive2.GetLength(0); k++)
            {
                massive3[i, j] += massive1[i, k] * massive2[k, j];
            }
        }
    }
    return massive3;
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

int[,] Create2DMassive(int size)
{
    int[,] massive = new int[size, size];
    for(int i = 0; i < size; i++)
    {
        for(int j = 0; j < size; j++)
        {
            massive[i, j] = new Random().Next(1, 10);
        }
    }
    return massive;
}

Console.WriteLine("Введите количество строк и столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = Create2DMassive(m);
Print2DMassive(matrix);
int[,] matrix2 = Create2DMassive(m);
Print2DMassive(matrix2);
int[,] matrix3 = FindMassivesProduct(matrix, matrix2);
Print2DMassive(matrix3);