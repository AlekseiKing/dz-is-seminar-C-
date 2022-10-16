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
        array[i, j] = new Random().Next(20); 
        Console.Write($"{array[i, j]} "); 
    } 
Console.WriteLine(); 
}
int a, b; int.TryParse(Console.ReadLine()!, out a); b = a % 10; a /= 10; 
if (a >= array.GetLength(0) || b >= array.GetLength(1) || a < 0) 
    Console.Write($"Такого числа нет в массиве!"); 
else
    {
    Console.Write($"{array[a, b]}");
    }
