// Задача №19.


class Program
{
    static void Main(string[] args)
    {
        int num, rem, sum = 0, temp;  
        Console.WriteLine("\n ----> ЯВЛЯЕТСЯ ЛИ ЧИСЛО ПАЛИНДРОМНЫН ИЛИ НЕТ <---- ");
        Console.Write("\n Введите число: ");
        num = Convert.ToInt32(Console.ReadLine()!);
        temp = num;
        while (num > 0)
        {
            rem = num % 10;  
            num = num / 10;
            sum = sum * 10 + rem;
        }
        Console.WriteLine("\n Перевернутое число равно: {0} \n", sum);
        if (temp == sum)
        {
            Console.WriteLine("\n Число является палиндромом \n\n");
        }
        else
        {
            Console.WriteLine("\n Число не является палиндромом \n\n");
        }
        Console.ReadLine();
    }
}