using System;
using System.Linq;

namespace ConsoleAppStart
{
    // РОБОТА БРОВДІ ВІТАЛІЙ, СА1, ЛАБ2, ВАР2
    class Program
    {
        static void Main(string[] args)
        {

            Zavd1();
            Zavd2();

        }
        static void Zavd1()
        {

            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            int[] myArray = new int[n];
            Random rand = new Random();
            int y = 1;


            // Генерування масису
            for (int x = 0; x < n; x++)
            {
                myArray[x] = rand.Next(-10, 30);
                Console.WriteLine("Значення елемента вектора " + x + " = " + myArray[x]);
            }

            // Розв'язок задачі
            for (int x = 0; x < n; x++)
            {
                myArray[x] = myArray[x] * y;
                y++;
                Console.WriteLine("Значення елемента вектора " + x + " пiсля змiни = " + myArray[x]);
            }
        }
        static void Zavd2()
        {
            // Генерація матриці
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m= ");
            int m = int.Parse(Console.ReadLine());
            int[,] mas = new int[n, m];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = rnd.Next(0, 100);
                    Console.Write(mas[i, j] + "\t");
                }
                Console.WriteLine();
            }
            // Вибір стовбців для заміни
            int k = 0;
            int p = 0;
            while (true)
            {
                Console.Write("k= ");
                k = int.Parse(Console.ReadLine());
                Console.Write("p= ");
                p = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                if (k == p ^ k - 1 > m ^ p - 1 > m ^ k == 0 ^ p == 0)
                {
                    Console.WriteLine("Не валiднi данi, введiть iншi k та p");
                }
                else break;
            }


            // Заміна стовпців
            for (int i = 0; i < n; i++)
            {
                mas[i, k - 1] = mas[i, k - 1] + mas[i, p - 1];
                mas[i, p - 1] = mas[i, k - 1] - mas[i, p - 1];
                mas[i, k - 1] = mas[i, k - 1] - mas[i, p - 1];
            }

            // Вивід матриці
            for (int el = 0; el < n; el++)
            {
                for (int elem = 0; elem < m; elem++)
                {
                    Console.Write(mas[el, elem] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
