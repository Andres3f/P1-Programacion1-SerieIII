using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorDeCorreoElectronico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido!");
            Console.Write("Por favor, ingresa tu nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ahora, ingresa tu apellido: ");
            string apellido = Console.ReadLine();

            Console.Write("Ingresa el dominio de correo electrónico (por ejemplo, gmail.com): ");
            string dominio = Console.ReadLine();

            string primerasLetrasNombre = nombre.Substring(0, Math.Min(nombre.Length, 3));
            string primerasLetrasApellido = apellido.Substring(0, Math.Min(apellido.Length, 3));

            string correoElectronico = $"{primerasLetrasNombre}{primerasLetrasApellido}@{dominio}";

            Console.WriteLine($"Tu correo electrónico generado es: {correoElectronico}");
        }
    }
}
