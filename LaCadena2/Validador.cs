using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCadena2
{
    public class Validador
    {
        public static void ContieneTexto(string subCadena, string cadena)
        {
            string s1 = cadena;
            string s2 = subCadena;
            bool b = s1.Contains(s2);
            
            if (b)
            {
                Console.Clear();
                Console.WriteLine("\n '{0}' está en la Cadena '{1}': {2}",
                            s2, s1, b);
                int index = s1.IndexOf(s2);
                if (index >= 0)
                    Console.WriteLine("\n '{0}' esta en la posición {1}",
                                  s2, index + 1);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n '{0}' No está en la Cadena '{1}': {2}",
                            s2, s1, b);
            }

        }

  
        public static void Despedida()
        {

            Console.WriteLine("\n Gracias por usar nuestro Sistema presione cualquier teclar para finalizar");
            Console.ReadKey();
        }

        public static string ValidarString(string mensaje)
        {

            string opcion;
            do
            {

                Console.WriteLine(mensaje);
                opcion = Console.ReadLine();
                if (string.IsNullOrEmpty(opcion))
                {
                    Console.Clear();
                    Console.WriteLine(" \nEl valor ingresado no puede ser vacio.");
                    Console.WriteLine(" Por favor ingrese un valor.");
                }
            } while (string.IsNullOrEmpty(opcion));
            return opcion;

        }
    }
}
