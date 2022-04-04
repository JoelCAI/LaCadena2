using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCadena2
{
    public class Sistema
    {
        public void MenuPrincipal()
        {
            string cadena;
            string subCadena = "fin";

            cadena = Validador.ValidarString("\n Ingrese una frase");

            Validador.ContieneTexto(subCadena,cadena);
            

            Validador.Despedida();
        }

        public void Iniciar()
        {
            MenuPrincipal();
        }
    }
}
