// Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет


Random rnd = new Random();
int[,] matrix = Generate2DArray(rnd.Next(3, 6), rnd.Next(3, 6));
Print2DArray(matrix);
int i = rnd.Next(0, 8);
int j = rnd.Next(0, 8);
PrintElementByIndicies(matrix, i, j);

void PrintElementByIndicies(int[,] matrix, int i, int j)
{
    Console.Write($"({i};{j}) -> {(IsContains(matrix, i, j) ? matrix[i, j] : "такого числа в массиве нет")}");
}

bool IsContains(int[,] matrix, int i, int j)
{
    return (i < matrix.GetLength(0) && j < matrix.GetLength(1));
}

int[,] Generate2DArray(int m, int n)
{
    int[,] result = new int[m, n];

    for(int i = 0; i < result.GetLength(0); i++)
    {
        for(int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(1, 100);
        }
    }
    return result;
}

void Print2DArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}