using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01._1bim
{
    public class FinanciamentoVeiculo
    {
        
        public double CalcularParcela(double valorVeiculo, int totalParcelas, double taxaMensal)
        {
            if (taxaMensal == 0)
                taxaMensal = 0.005; 

            double fator = Math.Pow(1 + taxaMensal, totalParcelas);
            return valorVeiculo * (taxaMensal * fator) / (fator - 1);
        }

        public double CalcularTotalPago(double parcela, int totalParcelas)
        {
            return parcela * totalParcelas;
        }
    }
}