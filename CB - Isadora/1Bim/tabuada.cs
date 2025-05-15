using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1bim
{
    public class Tabuada
    {
        public string Gerar(int numero)
        {
            string resultado = "";

            for (int i = 1; i <= 10; i++)
            {
                resultado += numero + " x " + i + " = " + (numero * i) + "\n";
            }

            return resultado;
        }
    }
}