/*   Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
элементов в промежутке от M до N.

M = 1; N = 15-> 120
M = 4; N = 8. -> 30
*/



int m, n, sum;
Console.Write($"Введите значение M: ");
int.TryParse(Console.ReadLine()!, out m);
Console.Write($"Введите значение N: ");
int.TryParse(Console.ReadLine()!, out n);
Console.WriteLine($"{NumbersSum(m, n)}");
int NumbersSum(int m, int n)
{
    if (m == n)return m;
    return n + NumbersSum(m, n - 1);
}