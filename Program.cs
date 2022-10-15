/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17->такого числа в массиве нет    */

int m = 4, n = 5; 
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
    for (int j = 0; j < n; j++) 
{ 
    int sum = 0; 
    for (int i = 0; i < m; i++)  
    { 
        sum += array[i, j]; 
    } 
Console.Write($"Среднее арифметическое {j + 1} столбца = {(double)sum / m}\n"); 
}