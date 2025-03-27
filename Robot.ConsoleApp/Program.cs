namespace Robot.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("digite o numero de qudrados da linha do grid: ");
                int area = Convert.ToInt32(Console.ReadLine());

                int numeroDeCasas;

                numeroDeCasas = area * area;

                Console.WriteLine($"Area é de: {numeroDeCasas} casas.");

                Console.ReadLine();
            }
        }
    }
}
