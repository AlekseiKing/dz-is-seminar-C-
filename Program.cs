/*
Задача 58:
Задайте две матрицы.
Напишите программу,
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
int[,] matrixA = new int[2, 2]
                {{2, 4},
                {3, 2}};

int[,] matrixB = new int[2, 2]
                {{3, 4},
                {3, 3}};

PrintArray(matrixA);
Console.WriteLine();
PrintArray(matrixB);
Console.WriteLine();
int[,] matrixC = MatrixProduct(matrixA, matrixB);
PrintArray(matrixC);

int[,] MatrixProduct(int[,] _matrixA, int[,] _matrixB)
{
    int[,] _matrixC = new int[_matrixA.GetLength(0), _matrixB.GetLength(1)];
    if (_matrixA.GetLength(1) != _matrixB.GetLength(0))
    {
        Console.WriteLine("Нельзя умножить матрицы");
        return _matrixC;
    }
    for (int i = 0; i < _matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < _matrixB.GetLength(1); j++)
        {
            int product = 0;
            for (int m = 0; m < _matrixA.GetLength(1); m++)
            {
                product += _matrixA[i, m] * _matrixB[m, j];
            }
            _matrixC[i, j] = product;
        }
    }
    return _matrixC;
}

void PrintArray(int[,] _array)
{
    for (int i = 0; i < _array.GetLength(0); i++)
    {
        for (int j = 0; j < _array.GetLength(1); j++)
            Console.Write($"{_array[i, j]} ");
        Console.WriteLine();
    }
}