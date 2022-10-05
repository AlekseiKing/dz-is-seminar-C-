// Задача №8.

int n;
Console.Write("Введите число N: ");
n = int.Parse(Console.ReadLine()!);

int i = 2;
while (i < n + 1)
{
    Console.Write($"{i} ");
    i+=2;
}