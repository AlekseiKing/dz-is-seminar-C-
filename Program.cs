// Задача №23.

int a = 0; 
Console.Write($"Введите число: "); 
int.TryParse(Console.ReadLine()!, out a); 
for (int i = 1; i <= a; i++) 
Console.Write($"{i * i * i} ");