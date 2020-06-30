using System;

namespace testProg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите первое число: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int c = Int32.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine("Сложение");
                    a = b + c;
                    Console.WriteLine($"Сумма двух чисел равна: {a}");
                    break;
                case 2:
                    Console.WriteLine("Вычетание");
                    a = b - c;
                    Console.WriteLine($"Сумма двух чисел равна: {a}");
                    break;
                case 3:
                    Console.WriteLine("Умножение");
                    a = b * c;
                    Console.WriteLine($"Сумма двух чисел равна: {a}");
                    break;
                default:
                    Console.WriteLine("Операция неопределена");
                    break;
            }
            // sometext
            Console.ReadKey();
        }
    }
}