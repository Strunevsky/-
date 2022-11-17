using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)


        {
            double a;
            double b;
            double otvet;
            char operation;

            Console.WriteLine("Введите A:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите операцию:");
            operation = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Введите В:");
            b = Convert.ToDouble(Console.ReadLine());
        }
                
            
        }
    }
}