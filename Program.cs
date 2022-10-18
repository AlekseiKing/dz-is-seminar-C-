/*   Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3->A(m, n) = 9
m = 3, n = 2->A(m, n) = 29
*/

/*
A(0, n) = n + 1; при n > 0;
A(m, 0) = A(m–1, 1); при m > 0;
A(m, n) = A(m–1, A(m, n–1)); при m > 0 и n > 0.
*/

int m, n;

Console.Write($"Введите пременную m: ");
int.TryParse(Console.ReadLine()!, out m);
Console.Write($"Введите пременную n: ");
int.TryParse(Console.ReadLine()!, out n);
Console.WriteLine($"--> {FuntionAckermann(m, n)}");
int FuntionAckermann(int _m, int _n)
{
    if (_m == 0)
        return _n + 1;
    else
    if ((_m != 0) && (_n == 0))
        return FuntionAckermann(_m - 1, 1);
    else
        return FuntionAckermann(_m - 1, FuntionAckermann(_m, _n - 1));
}
