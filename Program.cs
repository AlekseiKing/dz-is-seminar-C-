// Задача №10.

while (true)
{
    int rand = new Random().Next() % 1000;
    Console.WriteLine(rand);
    Console.WriteLine($"{(rand%100 - rand%10)/10}");
    Console.ReadKey();
}
