/*
Задача 56: 
Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить 
строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой 
строке и выдаёт номер строки с наименьшей 
суммой элементов: 1 строка
*/

int[,] array = new int[4, 4]{{1,4,7,2},
                            {5,9,2,3},
                            {8,4,2,4},
                            {5,2,6,7}};



Console.WriteLine("Минимальная сумма элементов"
+ $" по строкам в {MinLineArray(array)} строке ");
TestMineLineArray();

int MinLineArray(int[,] _array)
{
    int minLine = 0;
    int sum = 0;
    for (int j = 0; j < _array.GetLength(1); j++)
    {
        sum += _array[0, j];
    }
    int minSum = sum;
    for (int i = 1; i < _array.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < _array.GetLength(1); j++)
        {
            sum += _array[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            minLine = i;
        }
    }


    return minLine + 1;
}

void TestMineLineArray()
{
    int[,] array1 = new int[4, 4]{{2,2,2,2},
                                {3,3,3,3},
                                {3,3,3,3},
                                {3,3,3,3}};
    int[,] array2 = new int[4, 4]{{3,3,3,3},
                                {2,2,2,2},
                                {3,3,3,3},
                                {3,3,3,3}};
    int[,] array3 = new int[3, 4]{{3,3,3,3},
                                {3,3,3,3},
                                {2,2,2,2}};
    int[,] array4 = new int[4, 3]{{3,3,3},
                                {3,3,3},
                                {3,3,3},
                                {2,2,2}};
    if (MinLineArray(array1) == 1) Console.WriteLine("Test#1: Right!");
    else 
    Console.WriteLine("Test#1: Wrong!");
    if (MinLineArray(array2) == 2) Console.WriteLine("Test#2: Right!");
    else 
    Console.WriteLine("Test#2: Wrong!");
    if (MinLineArray(array3) == 3) Console.WriteLine("Test#3: Right!");
    else 
    Console.WriteLine("Test#3: Wrong!");
    if (MinLineArray(array4) == 4) Console.WriteLine("Test#4: Right!");
    else 
    Console.WriteLine("Test#4: Wrong!");
}