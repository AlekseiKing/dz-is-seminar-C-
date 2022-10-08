// Задача №25.

/*
Напишите функцию, используя цикл, который принимает на вход два числа 
(A и 😎 и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

using System;

class Program
{
    public static int Main()
    {
        Console.Write("Введите число   : ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Введите степень : ");
        int n = int.Parse(Console.ReadLine());
        int num_n = 1;
        for (int i = 0; i < n; i++)
        {
            num_n *= num;
        }
        Console.WriteLine("{0} ^ {1} = {2}", num, n, num_n);
        Console.ReadKey();
        return 0;
    }
}