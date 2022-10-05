// Задача №4.

int a, b, c, max;
Console.Write("Введите число a: ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write("Введите число b: ");
int.TryParse(Console.ReadLine()!, out b);
Console.Write("Введите число c: ");
int.TryParse(Console.ReadLine()!, out c);
max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.WriteLine(max);
