/*
Задача 62.
Напишите программу,
которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int m = 9, n = 3;
string[,] array = new string[m, n];
FillSpiral(array, m, n);
PrintArray(array);

void FillSpiral(string[,] _array, int _m, int _n)
{
    for (int padding = 0, currentChar = 1;
    padding < (_m < _n ? (_m / 2 + _m % 2) : (_n / 2 + _n % 2));
    padding++)
    {
        for (int j = padding; j < _n - padding; j++, currentChar++)
            _array[padding, j] = currentChar.ToString("00.##");
        for (int i = padding + 1; i < _m - padding; i++, currentChar++)
            _array[i, _n - padding - 1] = currentChar.ToString("00.##");
        for (int j = _n - padding - 2; j > padding - 1; j--, currentChar++)
            _array[_m - padding - 1, j] = currentChar.ToString("00.##");
        for (int i = _m - padding - 2; i > padding; i--, currentChar++)
            _array[i, padding] = currentChar.ToString("00.##");
    }
}

void PrintArray(string[,] _array)
{
    Console.WriteLine();
    for (int i = 0; i < _array.GetLength(0); i++)
    {
        for (int j = 0; j < _array.GetLength(1); j++)
            Console.Write($"{_array[i, j]} ");
        Console.WriteLine();
    }
}