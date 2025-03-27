namespace Robot.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("digite a area do Robô: ");
                int area = Convert.ToInt32(Console.ReadLine());

                int numeroDeCasas;

                numeroDeCasas = area * area;

                Console.WriteLine($"Area é de: {numeroDeCasas} casas.");

                Console.ReadLine();
            }
        }
    }
}
