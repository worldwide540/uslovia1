using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое число:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        if (num1 == num2)
        {
            Console.WriteLine("Числа равны");
        }
        else if (num1 > num2)
        {
            Console.WriteLine("Первое число больше второго");
        }
        else
        {
            Console.WriteLine("Первое число меньше второго");
        }
    }
}
