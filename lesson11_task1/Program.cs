using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson11_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа k и b для уравнения 0=kx+b");
            double k = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());


            LinearEquation eq = new LinearEquation(k, b);
            Console.WriteLine(eq.Root());
            Console.ReadKey();
        }
    }
}
