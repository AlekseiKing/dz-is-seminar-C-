// Задача №6.

int a;

Console.Write("Введите число а: ");
int.TryParse(Console.ReadLine()!, out a);
if (a % 2 == 0)
{
    Console.Write($"Да");
}
else
{
    Console.Write($"Нет");
}

