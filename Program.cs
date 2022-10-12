/* Задача 36: Задайте одномерный массив, заполненный случайными  числами. 
Найдите сумму элементов, стоящих на нечётных позициях. 
[3, 7, 23, 12] -> 19 [-4, -6, 89, 6] -> 0  */  

int[] _array = new int[new Random().Next(1, 17)];  
for (int i = 0; i < _array.Length; i++) 
    {     
        _array[i] = new Random().Next(0, 21);     
        Console.Write($"{_array[i]} ");
    }  
int F = 0;  
for (int i = 1; i < _array.Length; i += 2)     
F += _array[i];  
Console.Write($"--->>> {F}");