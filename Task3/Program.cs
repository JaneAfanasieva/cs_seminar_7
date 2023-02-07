// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Random rnd = new Random();
int[,] matrix = Generate2DArray(rnd.Next(3, 6), rnd.Next(3, 6));
Print2DArray(matrix);
double[] means = GetArithmeticMean(matrix);
System.Console.WriteLine($"Среднее арифметическое каждого столбца:");
PrintArray(means);

double[] GetArithmeticMean(int[,] matrix)
{
    double[] result = new double[matrix.GetLength(1)];

    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            result[j] = result[j] + matrix[i, j];
        }
    }
    for(int i = 0; i < result.Length; i++)
    {
        result[i] = result[i] / matrix.GetLength(0);
    }

    return result;
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

void PrintArray(double[] arr)
{
    foreach (double item in arr)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}