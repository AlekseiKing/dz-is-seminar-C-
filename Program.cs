/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2      */

int m = 6, n = 7; 
int[,] array = new int[m, n]; 
for (int i = 0; i < m; i++) 
{
    for (int j = 0; j < n; j++) 
    { 
        array[i, j] = new Random().Next(10); 
        Console.Write($"{array[i, j]} "); 
    } 
    Console.WriteLine(); 
}
for (int i = 0; i < m - 1; i++) 
{
    int temp = array[0, i]; array[0, i] = array[array.GetLength(0) - 1, i]; 
    array[array.GetLength(0) - 1, i] = temp; 
}
Console.WriteLine(); for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++) 
    Console.Write($"{array[i, j]} "); 
Console.WriteLine(); 
}