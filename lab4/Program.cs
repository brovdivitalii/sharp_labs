using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4and5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a:");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b:");
            var b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("h:");
            var h = Convert.ToInt32(Console.ReadLine());
            TRectangle firstR = new TRectangle(a,b);
            TRectangle secondR = new TRectangle();
            TParallelepiped firstP = new TParallelepiped(a,b,h);
            TParallelepiped secondP = new TParallelepiped();
            Console.WriteLine($"Площа Rectangle1: {firstR.Area()}");
            Console.WriteLine($"Площа Paralelepiped1: {firstP.Area()}");
            Console.WriteLine($"Периметр Rectangle2: {secondR.Perimetr()}");
            Console.WriteLine($"Периметр Paralelepiped2: {secondP.Perimetr()}");
            Console.WriteLine(firstR.Poriv(firstR,secondR));
            Console.ReadLine();

        }
         class TRectangle
        {
            public int a;
            public int b;
            public TRectangle()
            {
                a = b = 1;
            }
            public TRectangle(int a, int b)
            {
                this.a = a;
                this.b = b;
            }
            
            public void InputData()
            {
                Console.WriteLine("Введість сторону а:");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Введість сторону b:");
                b = int.Parse(Console.ReadLine());
            }
            public int Area()
            {
                return a* b;
            }
            public int Perimetr()
            { 
                return 2*(a+b); 
            }
            public bool Poriv(TRectangle line1, TRectangle line2)
            {
              if (line1.a == line2.a & line1.b == line2.b)
                {
                    return true;
                }
                if (line1.a % line2.a == 0 & line1.b % line2.b == 0)
                {
                    return true;
                }
                else return false;
            }
            public static string ShowLine(TRectangle line)
            {
                var str = $"a = {line.a}, b = {line.b}";
                return str;
            }
            public static TRectangle operator +(TRectangle line1, TRectangle line2)
            {
                return new TRectangle { a = line1.a + line2.a, b = line1.b + line2.b,};
            }
            public static TRectangle operator -(TRectangle line1, TRectangle line2)
            {
                return new TRectangle { a = line1.a - line2.a, b = line1.b - line2.b, };
            }
        }
         class TParallelepiped : TRectangle
        {
            public int h;
            public TParallelepiped()
            {
                a = b = h = 1;
            }
            public TParallelepiped(int a, int b, int h) : base(a,b)
            {
                this.h = h;
            }
            public int Area()
            {
                return a * b * h;
            }
            public int Perimetr()
            {
                return 2 * (h*a + h*b + a*b);
            }
            public void Poriv(TParallelepiped line)
            {
                if (a == line.a & b == line.b)
                {
                    Console.WriteLine("Прямокутники рівні");
                }
                if (a % line.a == 0 & b % line.b == 0)
                {
                    Console.WriteLine("Прямокутники пропорційні");
                }
                else Console.WriteLine("Прямокутники різні");
            }
            public int Volume()
            { return a * b * h; }
            public static string ShowLine(TParallelepiped line)
            {
                var str = $"a = {line.a}, b = {line.b}, h = {line.h}";
                return str;
            }
            public static TParallelepiped operator +(TParallelepiped line1, TParallelepiped line2)
            {
                return new TParallelepiped { a = line1.a + line2.a, b = line1.b + line2.b, h = line1.h + line2.h};
            }
            public static TParallelepiped operator -(TParallelepiped line1, TParallelepiped line2)
            {
                return new TParallelepiped { a = line1.a - line2.a, b = line1.b - line2.b, h = line1.h - line2.h };
            }
        }
    }   
}
