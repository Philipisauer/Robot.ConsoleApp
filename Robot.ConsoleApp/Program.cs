using System.Formats.Asn1;

namespace Robot.ConsoleApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Grid.ObterArea();

            while (true)
            {


                //robo
                int posicaoInicialX = 0;
                int posicaoInicialY = 0;
                string direcaoInicial = "n";

                Console.WriteLine("digite o valor de X:");
                int valorX = Convert.ToInt32(Console.ReadLine());

                if (valorX > Math.Pow(Grid.area, 2))
                {
                    Console.Clear();
                    Console.WriteLine("operaçao invalida!");
                    Grid.MostrarArea();
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("digite o valor de Y:");
                int valorY = Convert.ToInt32(Console.ReadLine());

                if (valorY > Math.Pow(Grid.area, 2))
                {
                Console.Clear();
                Console.WriteLine("operaçao invalida!");
                Grid.MostrarArea();
                Console.ReadLine();
                continue;
                }

                posicaoInicialX += valorX;
                posicaoInicialY += valorY;

                Console.WriteLine($"cordenadas atuais: X={posicaoInicialX} Y={posicaoInicialY} D={direcaoInicial}");

                Console.ReadLine();
            }
        }
    }
}
