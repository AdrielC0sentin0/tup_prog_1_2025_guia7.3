﻿using System;
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
            double promedio, num, i;
            int contador, acumulador;

            contador = 0;
            acumulador = 0;

            for (i= 1; i <= 20; i++)
            {
                Console.WriteLine("Ingresar el numero " + i);
                num = Convert.ToDouble(Console.ReadLine());

                acumulador = (int)(acumulador + num);
                contador += contador;
            }
            promedio = acumulador / 20;
            Console.WriteLine("El promedio de los numeros es: " + promedio);
        }
    }
}
