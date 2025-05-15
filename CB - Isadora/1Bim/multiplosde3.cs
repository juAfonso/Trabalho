using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1bim
{
    public class MultiplosDe3
    {
        public string Listar()
        {
            string resultado = "";

            for (int i = 0; i <= 100; i += 3)
            {
                resultado += i + "\n";
            }

            return resultado;
        }
    }
}