using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1bim
{
    public class CalculaDesconto
    {
        public float CalcularDesconto(float valorAtual, float percentualDesconto)
        {
            return valorAtual * percentualDesconto / 100;
        }

        public float CalcularValorFinal(float valorAtual, float desconto)
        {
            return valorAtual - desconto;
        }
    }
}