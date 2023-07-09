// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int L = 6; int S = 6;

int[,] GetArray(int L, int S)
{
    int[,] matrix = new int[L, S];
    matrix [0,0] = 1;

    for (int x = 0; x < matrix.GetLength(0)/2 + matrix.GetLength(0)%2; ++x)
    {
        if (x <= 1)
        {
            for (int i = 0+x; i < 1+x; ++i)
                for (int j = 1; j < matrix.GetLength(1)-x; ++j)
                        matrix [i,j] = matrix [i,j-1] + 1;
        }
        else
        {
            for (int i = 0+x; i < 1+x; ++i)
                for (int j = 1*x; j < matrix.GetLength(1)-x; ++j)
                    matrix [i,j] = matrix [i,j-1] + 1;
        }


        for (int j = matrix.GetLength(1)-1-x; j < matrix.GetLength(1)-x; ++j)
            for (int i = 1+x; i < matrix.GetLength(0)-x; ++i)
                matrix [i,j] = matrix [i-1,j] + 1;


        for (int i = matrix.GetLength(0)-1-x; i < matrix.GetLength(0); ++i)
            for (int j = matrix.GetLength(1)-2-x; j >= 0+x; --j)
                matrix [i,j] = matrix [i,j+1] + 1;


        for (int j = 0+x ; j < 1+x; ++j)
            for (int i = matrix.GetLength(0)-2-x; i > 0+x; --i)
                matrix [i,j] = matrix [i+1,j] + 1;

    }
    return matrix;
}

void PrintMatrixInts(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); ++i)
    {
        for (int j = 0; j < matrix.GetLength(1); ++j)
        {
            Console.Write($"{matrix[i, j]} (i{i}/j{j}) \t");
        }
        Console.WriteLine();
    }
}

int[,] MyMatrix = GetArray(L, S);
PrintMatrixInts(MyMatrix);
