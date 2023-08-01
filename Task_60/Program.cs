// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



void Print3DMassive(int[,,] massive)
{
    for(int i = 0; i < massive.GetLength(0); i++)
    {
        for(int j = 0; j < massive.GetLength(1); j++)
        {
            for(int k = 0; k < massive.GetLength(2); k++)
            {
                Console.WriteLine($"{massive[i, j, k]}({i},{j},{k})");
            }
        }
    }
}

int[,,] Create3DMassive(int size)
{
    int[,,] massive = new int[size, size, size];
    int value = 10;
    for(int i = 0; i < size; i++)
    {
        for(int j = 0; j < size; j++)
        {
            for(int k = 0; k < size; k++)
            {
                massive[i, j, k] = value;
                value++;
            }
        }
    }
    return massive;
}

Console.WriteLine("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,,] matrix = Create3DMassive(n);
Print3DMassive(matrix);