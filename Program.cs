//Задача №27.

/* Напишите программу, которая принимает на вход число и 
выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

using System;

public class Program
{
    public static void Main()
    {
        {
            int N, s = 0;
            Console.WriteLine("Введите  число ");
            N = Convert.ToInt32(Console.ReadLine());

            while (N > 0)
            {
                s += N % 10;
                N /= 10;
            }
            Console.WriteLine(" Сумма цифр числа = " + s);
        }
    }
}