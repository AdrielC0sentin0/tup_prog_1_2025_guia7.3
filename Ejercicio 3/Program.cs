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
            int num, mayor, menor, contador;
            contador = 0;

            Console.WriteLine("Ingrese un numero (o -1 para terminar)");
            num = Convert.ToInt32(Console.ReadLine());

            mayor = num;
            menor = num;

            while (num > -1)
            {
                if (contador == 0)
                {
                    mayor = num;
                    menor = num;
                }
                else if (num > mayor)
                {
                    mayor = num;
                }
                if ( num < menor )
                {
                    menor = num;
                }

                contador = contador + 1;

                Console.WriteLine("Ingrese otro numero (o -1 para terminar)");
                num = Convert.ToInt32(Console.ReadLine());
            }
            if (contador > 0 )
            {
                Console.WriteLine("El numero mayor es: " + mayor);
                Console.WriteLine("El numero menor es: " + menor);
            }
            else 
            {
                Console.WriteLine("No se ingresaron numeros validos");
            }
        }
    }
}
