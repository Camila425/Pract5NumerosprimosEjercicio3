using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNumerosprimos.Entidades
{
    public class Primo
    {
        //El atributo n es de tipo entero y privado
        private int n { get; set; }
        //Debe tener un método para informar dicho atributo.
       public int GetNUmero()
       {
            return n;
       }

        //  Otro atributo privado de tipo array de enteros donde se almacenarán los
        //términos generados
        private int[] numerosPrimos;



        //Definir 2 constructores, uno que tome un parámetro que inicializará el
        //atributo n y otro que no reciba parámetros que por defecto inicializará el
        //atributo n en 5.

        public Primo(int N)
        {
            n = N;

        }

        public Primo():this(5)
        {
            
        }



        //Definir un método para validar el objeto Primos.

        public bool Validar()
        {
         return   n>= 1;
        }


        //Definir un método que genere los términos de la serie.
        public void GenerarPrimos()
        {
            numerosPrimos = new int[n];

            int contadorPosiciones = 0;
            for (int i = 1; i < int.MaxValue; i++)
            {
                if (VerificarNroPrimo(i))
                {
                    numerosPrimos[contadorPosiciones] = i;
                    contadorPosiciones++;
                    if (contadorPosiciones==n)
                    {
                        break;
                    }
                }
            }
        }

        private bool VerificarNroPrimo(int i)
        {
            //Poner el algoritmo para ver si es primo el nro pasado
            return true;
        }

        //Definir un método público que me permita acceder a un término de la serie, si
        // el término no existiere arrojar una excepción.

       




    }
}
