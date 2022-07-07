using EjercicioNumerosprimos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3NumerosPrimos.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            var primo = new Primo();
            if (primo.Validar())
            {

            }
            else
            {
                Console.WriteLine("Objeto no válido");
            }

            Console.WriteLine($"");

        }
    }
}
