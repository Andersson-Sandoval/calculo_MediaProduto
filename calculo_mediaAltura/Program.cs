using System;
using System.Globalization;
namespace calculo_mediaAltura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos Produtos deseja calcular a Média? ");
          
            
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            Console.WriteLine("Digite o Nome e valor dos elementos:");

            for( int i = 0; i < n; i++ ) {

                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());


                vect[i] = new Product(name, price);
            
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Price;

            }

            double avg = sum / n;

            Console.WriteLine("A Média dos elementos é " + avg.ToString("F2", CultureInfo.InvariantCulture)) ; 


        }
    }
}
