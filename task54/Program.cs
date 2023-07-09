// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int rows = 3; int columns = 4;

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

int [,] StreamLine (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); ++i)
    {
        for (int j = 0; j < matrix.GetLength(1); ++j)
        {
            for (int k = j+1; k < matrix.GetLength(1); ++k)
            {
                if (matrix [i,j] < matrix [i,k])
                {
                    int tempNumb = matrix [i,j];
                    matrix [i,j] = matrix [i,k];
                    matrix [i,k] = tempNumb;
                }
            }
        }
    }
    return matrix;
}


int[,] MyMatrix = GetRandomArray(rows, columns);
PrintMatrixInts(MyMatrix);
Console.WriteLine();
MyMatrix = StreamLine(MyMatrix);
PrintMatrixInts(MyMatrix);