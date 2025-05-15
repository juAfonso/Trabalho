using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1bim
{
    public class Aposentadoria
    {
        public double CalcularMontante(int anosParaAposentar, double valorMensal, double taxaMensal)
        {
            int meses = anosParaAposentar * 12;
            double montante = 0;

            for (int i = 0; i < meses; i++)
            {
                montante += valorMensal;
                montante *= (1 + taxaMensal);
            }

            return montante;
        }
        
        public double CalcularRendaMensal(double montante, double taxaMensal)
        {
            return montante * taxaMensal;
        }
    }
}