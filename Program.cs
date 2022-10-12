/*  Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76   */

double[] array = new double[new Random().Next(6, 10)]; 
for (int i = 0; i < array.Length; i++)
    {
    array[i] = (double)new Random().Next(0, 10 * 10) / 10;
    Console.Write($"{array[i]}  ");
    }
double min = array[0];
double max = array[0];
foreach (var item in array) 
{
    if (min > item) min = item; 
    if (max < item) max = item; 
}
Console.Write($"\nmin = {min}  max = {max}  -->  {max - min}");



