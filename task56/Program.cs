// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int rows = 8; int columns = 3;

int[,] GetRandomArray(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); ++i)
        for (int j = 0; j < matrix.GetLength(1); ++j)
        {
            matrix[i, j] = Random.Shared.Next(0, 10); // [0,10)
        }
    return matrix;
}

void PrintMatrixInts(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); ++i)
    {
        for (int j = 0; j < matrix.GetLength(1); ++j)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void SumLine (int[,] matrix)
{
    int[] sumLineArray = new int [matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); ++i)
    {
        for (int j = 0; j < matrix.GetLength(1); ++j)
        {
            sumLineArray[i] = sumLineArray[i] + matrix [i,j];
            
        }
    }
    Console.WriteLine($"[{string.Join(", ", sumLineArray)}]");
    int minSumLine = sumLineArray[0];
    int result = 0;
    for (int i = 1; i < sumLineArray.Length; ++i)
        if (minSumLine > sumLineArray[i])
        {
            result = i;
            minSumLine = sumLineArray[i];
        }
    Console.WriteLine($"Программа посчитала сумму элементов в каждой строке и сообщает вам, номер строки с наименьшей суммой элементов: {result}");
}


int[,] MyMatrix = GetRandomArray(rows, columns);
PrintMatrixInts(MyMatrix);
Console.WriteLine();
SumLine(MyMatrix);