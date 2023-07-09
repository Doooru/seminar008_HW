// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 6 16
// 9 6

int rows = 2; int columns = 2;

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

int[,] MultiplicationArray (int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] matrix = new int[firstMatrix.GetLength(0), firstMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); ++i)
    {
        for (int j = 0; j < firstMatrix.GetLength(1); ++j)
        {
        matrix[i,j] = firstMatrix [i,j] * secondMatrix [i,j];
        }
    }
    return matrix;
}

int[,] MyFirstMatrix = GetRandomArray(rows, columns);
int[,] MySecondMatrix = GetRandomArray(rows, columns);
int[,] MyMatrixResult = MultiplicationArray(MyFirstMatrix, MySecondMatrix);
PrintMatrixInts(MyFirstMatrix);
Console.WriteLine();
PrintMatrixInts(MySecondMatrix);
Console.WriteLine();
PrintMatrixInts(MyMatrixResult);


