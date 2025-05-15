using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1bim
{
    public class Fatorial
    {
        public string Calcular()
        {
            string resultado = "";

            for (int i = 1; i <= 10; i++)
            {
                int fatorial = 1;
                for (int j = 1; j <= i; j++)
                {
                    fatorial *= j;
                }
                resultado += "Fatorial de " + i + " = " + fatorial + "\n";
            }

            return resultado;
        }
    }
}