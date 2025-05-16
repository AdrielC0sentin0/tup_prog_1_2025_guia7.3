using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opinion, positivo, negativo, indecisos, cantidad, i;
            positivo = 0;
            negativo = 0;
            indecisos = 0;

            Console.WriteLine("Cuantas opiniones ingresaran");
            cantidad = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= cantidad; i++)
            {
                Console.WriteLine("Ingrese opinion "+ i + " (0 = Positivo, 1 = Negativo, 2 = Indecisos): ");
                opinion = Convert.ToInt32(Console.ReadLine());

                switch (opinion)
                {
                    case 0:
                        positivo = positivo + 1;
                        break;

                    case 1:
                        negativo = negativo + 1;
                        break;

                    case 2:
                        indecisos = indecisos + 1;
                        break;
                }
            }
            Console.WriteLine("Resultados: ");
            Console.WriteLine("Positivos: "+ (positivo * 100) / cantidad+ "%");
            Console.WriteLine("Negativos: "+ (negativo * 100) / cantidad + "%");
            Console.WriteLine("Indecisos: "+ (indecisos * 100) / cantidad + "%");
        }
    }
}
