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
            int promedio, acumulador, contador, num;

            Console.WriteLine("Ingrese un numero entre (0 = False a 100 = True)");
            num = Convert.ToInt32(Console.ReadLine());

            contador = 0;
            acumulador = 0;

            while (num > 0)
            {
                Console.WriteLine("Ingrese un numero entre (0 = False a 100 = True)");
                num = Convert.ToInt32(Console.ReadLine());

                acumulador = acumulador + num;
                contador = contador + 1;
            }
            promedio = acumulador / contador;
            Console.WriteLine("El promedio de los numeros ingresados es: " + promedio);
        }
    }
}
