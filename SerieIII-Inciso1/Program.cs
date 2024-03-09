using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieIII_Inciso1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Hola :), ingrese el precio del primer producto ");
            string numeroIngresado = Console.ReadLine();
            float num1 = float.Parse(numeroIngresado);
            Console.WriteLine("Ingrese el precio del segundo producto: ");
            string segundoNumeroIngresado = Console.ReadLine();
            float num2 = float.Parse(segundoNumeroIngresado);
            Console.WriteLine("Ingrese el precio del tercer producto: ");
            string tercerNumeroIngresado = Console.ReadLine();
            float num3 = float.Parse(segundoNumeroIngresado);
            float resultado = num1 + num2 + num3;
            Console.WriteLine("La suma de los precios {0} + {1} + {2} es de: {3}", num1, num2, num3, resultado);
            Console.ReadLine();

        }


    }
}
