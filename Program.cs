// Задача №13.

int a;
while (true)
{
    Console.Write("Введите числ: ");
    int.TryParse(Console.ReadLine()!, out a);
    if (a < 100) Console.WriteLine("Третьей цифры нет");
    else
    {
        for(;a>=1000;a/=10);
        Console.WriteLine($"Третья цифра: {a%10}");
    }
}
