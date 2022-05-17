using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Program
    {
        class Vector
        {
            private int _n;
            private double[] _array;
            public Vector(int n)
            {
                _n = n;
                _array = new double[n];
                for (int i = 0; i < n; i++)
                {
                    _array[i] = 0;
                }
            }
            public Vector(double[] array)
            {
                _array = array;
                _n = _array.Length;
            }
            public void inputVector()
            {
                for (int x = 0; x < _n; x++)
                {
                    Console.Write("Значення елемента вектора " + x + " = ");
                    _array[x] = double.Parse(Console.ReadLine());
                }
            }
            public double lenghtVector()
            {
                double sum = 0;
                for (int i = 0; i < _n; i++)
                {
                    sum += _array[i] * _array[i];
                }
                sum = Math.Sqrt(sum);
                return sum;
            }
            public double[] normaVector()
            {
                double[] massive = _array;

                for (int i = 0; i < _n; i++)
                {
                    massive[i] = massive[i] / this.lenghtVector();
                }
                return massive;
            }
            public override string ToString()
            {
                return string.Format($"({string.Join(" ", _array)})");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введіть значення n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            var m = new Vector(n);
            m.inputVector();
            Console.WriteLine($"Довжина = {m.lenghtVector()} \n" +
                              $"Норма = {string.Join(" ", m.normaVector())}\n");
            Console.WriteLine($"Вектор = {m}");
        }
    }


}