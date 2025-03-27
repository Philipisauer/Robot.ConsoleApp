using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.ConsoleApp
{
    class Grid
    {
        public static void area() 
        {
            Console.WriteLine("digite o numero de qudrados da linha do grid: ");
            int area = Convert.ToInt32(Console.ReadLine());

            int numeroDeCasas;

            numeroDeCasas = area * area;

            Console.WriteLine($"Area é de: {numeroDeCasas} casas.");
        }
    }
}
