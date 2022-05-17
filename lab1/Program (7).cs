using System;
using System.Linq;
namespace ConsoleAppStart
{
    // РОБОТА БРОВДІ ВІТАЛІЙ, СА1, ВАР2
    class Program
    {
        static void Main(string[] args)
        {
            // ЗАВД 1, ВАР 2 = Задано 4-х цифрове натуральне число n.
            // Визначити добуток найбільшої та найменшої цифри цього числа.

            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());

            int[] numbers = new int[4];

            numbers[3] = k % 10;

            numbers[2] = (k / 10) % 10;

            numbers[1] = (k / 100) % 10;

            numbers[0] = (k / 1000);

            int max = numbers.Max();
            int min = numbers.Min();

            Console.WriteLine("Завд 1, відповідь: " + (max * min));


            // ЗАВД 2, ВАР 2 = Дано три дійсних числа a, b, c.
            // Знайти: y=max(min(a*b, a*c), min( a+c, b+c)).
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            double y = Math.Max(Math.Min(a * b, a * c), Math.Min(a + b, b + c));

            Console.WriteLine("Завд 2, відповідь: y = " + y);
        }
    }
}