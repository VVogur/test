using System;

namespace testProg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                break;
}
            while (num1 < 0 || num1 > 10 || num2 < 0 || num2 > 10);
            {
                if (num1 < 0 || num1 > 10 || num2 < 0 || num2 > 10)
                { 
                    Console.WriteLine("Оба числа должны быть в диапазоне от 0 до 10"); 
                }
                

            }
                Console.ReadKey();
        }
    }
}