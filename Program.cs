/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)   */

double k1, k2, b1, b2, x, y;
Console.Write($"Введите значение b1: ");
double.TryParse(Console.ReadLine()!, out b1);
Console.Write($"Введите значение b2: ");
double.TryParse(Console.ReadLine()!, out b2);
Console.Write($"Введите значение k1: ");
double.TryParse(Console.ReadLine()!, out k1);
Console.Write($"Введите значение k2: ");
double.TryParse(Console.ReadLine()!, out k2);
x = (b2 - b1) / (k1 - k2);
y = k1 * x + b1;
Console.Write($"--->>> x =: {x} ");
Console.Write($"--->>> y =: {y} ");