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
            int num, mayor, menor, i;

            Console.WriteLine("Ingrese el numero 1");
            num = Convert.ToInt32(Console.ReadLine());

            mayor = num;
            menor = num;

            for (i = 2; i <= 30; i++)
            {
                Console.WriteLine("Ingrese el numero " + i);
                num = Convert.ToInt32(Console.ReadLine());

                if (num > mayor)
                {
                    mayor = num;
                }

                if (num < menor)
                {
                    menor = num;
                }
            }

            Console.WriteLine("El numero: "+ mayor+ " Es el Mayor");
            Console.WriteLine("El numero: " + menor + " Es el Menor");
        }
    }
}
