using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Pratico
{
    class Program
    {
        static void Main(string[] args)
        {
            // Locadora de Filmes

            double precoNormalDVD = 30.0;
            string categoria1 = "comum"; string categoria2 = "Lançamento";
            byte dia;

            Console.WriteLine("Digite um Número: ");
            dia = Convert.ToByte(Console.ReadLine());
            Console.ReadKey();

            switch (dia)
            {
                case 1:
                    {
                        Console.WriteLine("Às quartas, sextas, sábados e domingos (4, 6, 7 e 1): preço normal!");
                        Console.ReadLine();
                        break;
                    }
                case 2:
                    {
                        double perc = (precoNormalDVD * 40 / 100);
                        Console.WriteLine("Às segundas, terças e quintas (2, 3 e 5): desconto de 40% em relação ao preço normal!\nValor com desconto: " + perc);
                        Console.ReadLine();
                        break;
                    }
                case 3:
                    {
                        double perc = (precoNormalDVD * 40 / 100);
                        Console.WriteLine("Às segundas, terças e quintas (2, 3 e 5): desconto de 40% em relação ao preço normal!\nValor com desconto: " + perc);
                        Console.ReadLine();
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Às quartas, sextas, sábados e domingos (4, 6, 7 e 1): preço normal!!");
                        Console.ReadLine();
                        break;
                    }
                case 5:
                    {
                        double perc = (precoNormalDVD * 40 / 100);
                        Console.WriteLine("Às segundas, terças e quintas (2, 3 e 5): desconto de 40% em relação ao preço normal!\nValor com desconto: " + perc);
                        Console.ReadLine();
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Às quartas, sextas, sábados e domingos (4, 6, 7 e 1): preço normal!");
                        Console.ReadLine();
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Às quartas, sextas, sábados e domingos (4, 6, 7 e 1): preço normal!");
                        Console.ReadLine();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Opção Inválida!");
                        Console.ReadLine();
                        break;
                    }
            }
        }
    }
}
