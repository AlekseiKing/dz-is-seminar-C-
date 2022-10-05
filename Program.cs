// Задача №2.

int a, b;
Console.Write("Введите число a: ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write("Введите число b: ");
int.TryParse(Console.ReadLine()!, out b);
if 
(a > b) Console.WriteLine($"max = {a}, min = {b}");
else 
Console.WriteLine($"max = {b}, min = {a}");
