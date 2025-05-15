using System;

namespace Aula01._1bim
{
    public class CalculoImposto
    {
        public double Calcular(double renda, int dependentes)
        {
            renda -= dependentes * 189.59;

            if (renda <= 1903.98)
                return 0;
            else if (renda <= 2826.65)
                return renda * 0.075 - 142.80;
            else if (renda <= 3751.05)
                return renda * 0.15 - 354.80;
            else if (renda <= 4664.68)
                return renda * 0.225 - 636.13;
            else
                return renda * 0.275 - 869.36;
        }
    }
}