/* Задача 34: Задайте массив заполненный случайными положительными  
трёхзначными числами. Напишите программу, которая покажет количество  
чётных чисел в массиве. [345, 897, 568, 234] -> 2 */

int[] array = new int[new Random().Next(2, 12)]; 
for (int i = 0; i < array.Length; i++) 
    {
    array[i] = new Random().Next(100, 1000); 
    Console.Write($"{array[i]} "); 
    }
int F = 0; 
foreach (var item in array) if (item % 2 == 0) F++; 
Console.Write($"-->{F}");