/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"   */


int a;
Console.Write($"Введите число N: ");
int.TryParse(Console.ReadLine()!, out a);
PrintNumbers(a, 1);
void PrintNumbers(int _start, int _end)
{
    if (_start != _end)
    {
        Console.Write($"{_start} ");
        PrintNumbers(_start - 1, _end);
    }
    else Console.Write($"{_end}");
}
