// Задача №15.

int day;
Console.WriteLine("Выводит Да, если выходной. Иначе - нет");
Console.Write("Введите день недели от 1 до 7: ");
int.TryParse(Console.ReadLine()!, out day);
if 
(day==6 || day ==7) Console.Write("Да");
else 
Console.Write("Нет");

