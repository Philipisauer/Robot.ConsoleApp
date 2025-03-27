using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.ConsoleApp
{
    public class Grid
    {
        public static int area = 0;
        public static int numeroDeCasas;
        public static void ObterArea() 
        {
            Console.WriteLine("digite o numero de qudrados da linha do grid: ");
            area = Convert.ToInt32(Console.ReadLine());

            numeroDeCasas = area * area;

            Console.WriteLine($"Area é de: {numeroDeCasas} casas.");
        }
        public static int MostrarArea() 
        {
            Console.WriteLine($"Area é de: {numeroDeCasas} casas.");
            return numeroDeCasas;
        }
    }
}
